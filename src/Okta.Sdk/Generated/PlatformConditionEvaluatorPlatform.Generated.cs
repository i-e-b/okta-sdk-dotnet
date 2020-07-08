// <copyright file="PlatformConditionEvaluatorPlatform.Generated.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

// This file was automatically generated. Don't modify it directly.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Okta.Sdk.Internal;

namespace Okta.Sdk
{
    /// <inheritdoc/>
    public sealed partial class PlatformConditionEvaluatorPlatform : Resource, IPlatformConditionEvaluatorPlatform
    {
        /// <inheritdoc/>
        public IPlatformConditionEvaluatorPlatformOperatingSystem Os 
        {
            get => GetResourceProperty<PlatformConditionEvaluatorPlatformOperatingSystem>("os");
            set => this["os"] = value;
        }
        
        /// <inheritdoc/>
        public string Type 
        {
            get => GetStringProperty("type");
            set => this["type"] = value;
        }
        
    }
}