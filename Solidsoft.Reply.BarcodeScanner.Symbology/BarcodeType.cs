// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BarcodeType.cs" company="Solidsoft Reply Ltd">
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
// An enumeration of barcode types.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable CommentTypo
namespace Solidsoft.Reply.BarcodeScanner.Symbology;

/// <summary>
///   An enumeration of barcode types.
/// </summary>
public enum BarcodeType {
    /// <summary>
    ///   No identifier is available.
    /// </summary>
    NoIdentifier,

    /// <summary>
    ///   The identifier is unknown.
    /// </summary>
    Unknown,

    /// <summary>
    ///   Code 39 type.
    /// </summary>
    Code39,

    /// <summary>
    ///   Telepen type.
    /// </summary>
    // ReSharper disable once IdentifierTypo
    Telepen,

    /// <summary>
    ///   Code 128 type.
    /// </summary>
    Code128,

    /// <summary>
    ///   Data Matrix type.
    /// </summary>
    DataMatrix,

    /// <summary>
    ///   GS1 DataBar type.
    /// </summary>
    Gs1DataBar,

    /// <summary>
    ///   UPC A, UPC E, EAN-8 and EAN-13 types.
    /// </summary>
    UpcEan,

    /// <summary>
    ///   Codabar type.
    /// </summary>
    // ReSharper disable once IdentifierTypo
    Codabar,

    /// <summary>
    ///   Code 93 type.
    /// </summary>
    Code93,

    /// <summary>
    ///   Code 11 type.
    /// </summary>
    Code11,

    /// <summary>
    ///   Interleaved 2 of 5 type. Includes ITF-14.
    /// </summary>
    Interleaved2Of5,

    /// <summary>
    ///   Dot code Data type.
    /// </summary>
    DotCode,

    /// <summary>
    ///   PDF 417 type.
    /// </summary>
    Pdf417,

    /// <summary>
    ///   MSI Code type.
    /// </summary>
    MsiCode,

    /// <summary>
    ///   Codablock type.
    /// </summary>
    // ReSharper disable once IdentifierTypo
    Codablock,

    /// <summary>
    ///   Pharmacode type.
    /// </summary>
    // ReSharper disable once IdentifierTypo
    Pharmacode,

    /// <summary>
    ///   Plessey Code type.
    /// </summary>
    // ReSharper disable once IdentifierTypo
    PlesseyCode,

    /// <summary>
    ///   QR Code / Micro QR Code types.
    /// </summary>
    QrCode,

    /// <summary>
    ///   Standard 2 of 5 type.
    /// </summary>
    Standard2Of5,

    /// <summary>
    ///   Industrial 2 of 5 type.
    /// </summary>
    Industrial2Of5,

    /// <summary>
    ///   X - Other Symbology AIM type.
    /// </summary>
    Other,

    /// <summary>
    ///   Aztec type.
    /// </summary>
    Aztec,

    /// <summary>
    ///   Non-Barcode Data type.
    /// </summary>
    NonBarcodeData,
}