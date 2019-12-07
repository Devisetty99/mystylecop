﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace StyleCop.Analyzers.Test.DocumentationRules
{
    using Microsoft.CodeAnalysis;
    using StyleCop.Analyzers.DocumentationRules;
    using Xunit;

    /// <summary>
    /// This class contains unit tests for <see cref="SA1628DocumentationTextMustBeginWithACapitalLetter"/>.
    /// </summary>
    public class SA1628UnitTests
    {
        [Fact]
        public void TestDisabledByDefaultAndNotConfigurable()
        {
            var analyzer = new SA1628DocumentationTextMustBeginWithACapitalLetter();
            Assert.Single(analyzer.SupportedDiagnostics);
            Assert.False(analyzer.SupportedDiagnostics[0].IsEnabledByDefault);
            Assert.Contains(WellKnownDiagnosticTags.NotConfigurable, analyzer.SupportedDiagnostics[0].CustomTags);
        }
    }
}