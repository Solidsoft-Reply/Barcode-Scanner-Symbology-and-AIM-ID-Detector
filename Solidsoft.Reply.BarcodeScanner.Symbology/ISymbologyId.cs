// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISymbologyId.cs" company="Solidsoft Reply Ltd">
// Copyright (c) 2018-2024 Solidsoft Reply Ltd. All rights reserved.
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
// </copyright>
// <summary>
// Represents the symbology identifier.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Solidsoft.Reply.BarcodeScanner.Symbology;

/// <summary>
///   Represents the symbology identifier.
/// </summary>
public interface ISymbologyId {
    /// <summary>
    ///   Gets the barcode data without an AIM identifier.
    /// </summary>
    string BarcodeData { get; }

    /// <summary>
    ///   Gets the barcode type.
    /// </summary>
    BarcodeType BarcodeType { get; }

    /// <summary>
    ///   Gets the symbology identifier character(s).
    /// </summary>
    string Id { get; }

    /// <summary>
    ///   Gets the AIM modifier.
    /// </summary>
    char Modifier { get; }

    /// <summary>
    ///   Gets the symbology identification scheme.
    /// </summary>
    // ReSharper disable once UnusedMember.Global
    SymbologyIdScheme Scheme { get; }
}