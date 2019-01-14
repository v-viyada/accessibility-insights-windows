// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Globalization;
using AccessibilityInsights.Core.Bases;
using AccessibilityInsights.Core.Enums;
using AccessibilityInsights.Rules.PropertyConditions;
using AccessibilityInsights.Rules.Resources;
using static AccessibilityInsights.Rules.PropertyConditions.ControlType;

namespace AccessibilityInsights.Rules.Library
{
    [RuleInfo(ID = RuleId.ContentViewSpinnerStructure)]
    class ContentViewSpinnerStructure: Rule
    {
        public ContentViewSpinnerStructure()
        {
            this.Info.Description = string.Format(CultureInfo.InvariantCulture, Descriptions.Structure, ContentView.SpinnerStructure);
            this.Info.Standard = A11yCriteriaId.InfoAndRelationships;
        }

        public override EvaluationCode Evaluate(IA11yElement e)
        {
            if (e == null) throw new ArgumentException(nameof(e));

            return ContentView.SpinnerStructure.Matches(e) ? EvaluationCode.Pass : EvaluationCode.Note;
        }

        protected override Condition CreateCondition()
        {
            return Spinner;
        }
    } // class
} // namespace
