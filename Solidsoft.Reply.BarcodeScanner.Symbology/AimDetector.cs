// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AimDetector.cs" company="Solidsoft Reply Ltd.">
//   (c) 2018-2024 Solidsoft Reply Ltd. All rights reserved.
// </copyright>
// <license>
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </license>
// <summary>
// Detects the AIM symbology reported by the barcode scanner.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

[assembly: CLSCompliant(true)]
namespace Solidsoft.Reply.BarcodeScanner.Symbology;

using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

/// <summary>
///   Detects the AIM symbology reported by the barcode scanner.
/// </summary>
[SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1650:ElementDocumentationMustBeSpelledCorrectly",
    Justification = "Reviewed. Suppression is OK here.")]
#if NET7_0_OR_GREATER
public partial class AimDetector : IDetector
{
    /// <summary>
    ///   Regular expression to test for Latin alphabetic character.
    /// </summary>
    /// <returns></returns>
    [GeneratedRegex("[a-z]\\d", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant)]
    private static partial Regex AimId();
#else
public class AimDetector : IDetector
{
    /// <summary>
    ///   Regular expression to test for Latin alphabetic character.
    /// </summary>
    /// <returns></returns>
    private static readonly Regex AimId = new("[a-z]\\d", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);
#endif
    /// <summary>
    ///   Analyze the symbology by inspecting the AIM identifier.
    /// </summary>
    /// <param name="data">
    ///   The data to be parsed.
    /// </param>
    /// <returns>
    ///   The <see cref="AimId" />.
    ///   The AIM symbology identifier.
    /// </returns>
    public ISymbologyId Detect(string data)
    {
        // Is any data present?
        if (string.IsNullOrWhiteSpace(data))
        {
            // Handle AIM identifier for empty data.
            return new AimId(string.Empty, string.Empty);
        }

        var dataCharacters = data.ToCharArray();
        var aimIdChars = dataCharacters.Length >= 3 ? string.Concat(dataCharacters[1], dataCharacters[2]) : string.Empty;

        // Get the AIM ID, if it exists.
        return dataCharacters[0] == ']'
                   ? TestDataCharactersLengthGt2()
                   : new AimId(string.Empty, data);

        ISymbologyId TestDataCharactersLengthGt2() => dataCharacters.Length > 2
            ? TestAimIdMatch()
            : new AimId(string.Empty, data);

        ISymbologyId TestAimIdMatch() =>
#if NET7_0_OR_GREATER
            AimId()
#else
            AimId
#endif
                .IsMatch(aimIdChars)
                ? new AimId(aimIdChars, TestDataCharactersLengthGt3())
                : new AimId(string.Empty, data);

        string TestDataCharactersLengthGt3() => 
            dataCharacters.Length > 3 
                ? data
#if NET6_0_OR_GREATER
                    [3..]
#else
                    .Substring(3)
#endif
                : string.Empty;
    }
}