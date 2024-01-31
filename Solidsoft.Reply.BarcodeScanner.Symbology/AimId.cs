// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AimId.cs" company="Solidsoft Reply Ltd.">
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
// Represents an AIM symbology identifier.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Solidsoft.Reply.BarcodeScanner.Symbology;

using System.Diagnostics.CodeAnalysis;

/// <summary>
///   Represents an AIM symbology identifier.
/// </summary>
[SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1650:ElementDocumentationMustBeSpelledCorrectly",
    Justification = "Reviewed. Suppression is OK here.")]
public class AimId : ISymbologyId
{
    /// <summary>
    ///   Initializes a new instance of the <see cref="AimId" /> class.
    /// </summary>
    /// <param name="id">
    ///   The AIM identifier.
    /// </param>
    /// <param name="barcodeData">
    ///   The barcode data without the AIM ID.
    /// </param>
    public AimId(string id, string barcodeData)
    {
        Id = id;
        BarcodeData = barcodeData;
    }

    /// <summary>
    ///   Gets the barcode data without an AIM identifier.
    /// </summary>
    public string BarcodeData { get; }

    /// <summary>
    ///   Gets the barcode type.
    /// </summary>
    public BarcodeType BarcodeType
    {
        get
        {
            if (Id.Length == 0)
            {
                return BarcodeType.NoIdentifier;
            }

            return Id[0] switch
                   {
                       'A' => BarcodeType.Code39,
                       'B' => BarcodeType.Telepen,
                       'C' => BarcodeType.Code128,
                       'd' => BarcodeType.DataMatrix,
                       'e' => BarcodeType.Gs1DataBar,
                       'E' => BarcodeType.UpcEan,
                       'F' => BarcodeType.Codabar,
                       'G' => BarcodeType.Code93,
                       'H' => BarcodeType.Code11,
                       'I' => BarcodeType.Interleaved2Of5,
                       'J' => BarcodeType.DotCode,
                       'L' => BarcodeType.Pdf417,
                       'M' => BarcodeType.MsiCode,
                       'O' => BarcodeType.Codablock,
                       'p' => BarcodeType.Pharmacode,
                       'P' => BarcodeType.PlesseyCode,
                       'Q' => BarcodeType.QrCode,
                       'R' => BarcodeType.Standard2Of5,
                       'S' => BarcodeType.Industrial2Of5,
                       'X' => BarcodeType.Other,
                       'z' => BarcodeType.Aztec,
                       'Z' => BarcodeType.NonBarcodeData,
                       _   => BarcodeType.Unknown
                   };
        }
    }

    /// <summary>
    ///   Gets the symbology identifier character(s)
    /// </summary>
    public string Id { get; }

    /// <summary>
    ///   Gets the AIM modifier.
    /// </summary>

    // ReSharper disable once UnusedMember.Global
    public char Modifier => Id.Length == 0 ? char.MinValue : Id[1];

    /// <summary>
    ///   Gets the symbology identification scheme.
    /// </summary>
    public SymbologyIdScheme Scheme => SymbologyIdScheme.Aim;
}