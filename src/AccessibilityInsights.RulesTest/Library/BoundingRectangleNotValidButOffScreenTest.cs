// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationCode = AccessibilityInsights.Rules.EvaluationCode;

namespace AccessibilityInsights.RulesTest.Library
{
    [TestClass]
    public class BoundingRectangleNotValidButOffScreenTest
    {
        private static AccessibilityInsights.Rules.IRule Rule = new AccessibilityInsights.Rules.Library.BoundingRectangleNotValidButOffScreen();

        [TestMethod]
        public void TestBoundingRectangleNotValidButOffScreenInformation()
        {
            Assert.AreEqual(Rule.Evaluate(null), EvaluationCode.Note);
        }
    }
}
