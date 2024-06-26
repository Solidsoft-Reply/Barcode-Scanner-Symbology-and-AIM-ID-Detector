﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDetector.cs" company="Solidsoft Reply Ltd">
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
// Represents a symbology detector.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Solidsoft.Reply.BarcodeScanner.Symbology;

/// <summary>
///   Represents a symbology detector.
/// </summary>
public interface IDetector {
    /// <summary>
    ///   Analyze the symbology by inspecting the symbology identifier.
    /// </summary>
    /// <param name="data">
    ///   The data to be parsed.
    /// </param>
    /// <returns>
    ///   The <see cref="ISymbologyId" />.
    ///   The symbology identifier.
    /// </returns>
    // ReSharper disable once UnusedMember.Global
    // ReSharper disable once UnusedMemberInSuper.Global
    ISymbologyId Detect(string data);
}