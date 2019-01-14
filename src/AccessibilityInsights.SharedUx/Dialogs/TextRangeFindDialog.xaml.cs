// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using AccessibilityInsights.Desktop.Types;
using AccessibilityInsights.SharedUx.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using AccessibilityInsights.Desktop.UIAutomation.Support;
using AccessibilityInsights.DesktopUI.Highlighters;
using AccessibilityInsights.Core.Enums;
using System.Globalization;

namespace AccessibilityInsights.SharedUx.Dialogs
{
#pragma warning disable CA1001 // Types that own disposable fields should be disposable. but here we do dispose it at window close. 
    /// <summary>
    /// Interaction logic for TextRangeFindDialog.xaml
    /// </summary>
    public partial class TextRangeFindDialog : Window
#pragma warning restore CA1001 // Types that own disposable fields should be disposable
    {
        private TextRangeViewModel ViewModel;
        private TextRangeHilighter Hilighter;
        private TextRangeFinder Finder;

        public TextRangeFindDialog(TextRangeViewModel trvm)
        {
            this.ViewModel = trvm;
            InitializeComponent();
            this.cbAttributes.ItemsSource = TextAttributeType.GetInstance().GetTemplate();
            this.Hilighter = new TextRangeHilighter(HighlighterColor.GreenTextBrush); // green color
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // select first item "Text"
            this.cbAttributes.SelectedIndex = 0;
        }

        private void cbAttributes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = cbAttributes.SelectedItem as Tuple<int, string, dynamic, Type>;
            if (item != null)
            {
                this.Hilighter.HilightBoundingRectangles(false);

                if(item.Item3 is List<KeyValuePair<int, string>> || item.Item3 is List<KeyValuePair<bool, string>>)
                {
                    cbValues.ItemsSource = item.Item3;
                    cbValues.SelectedIndex = 0;
                    tbValue.Visibility = Visibility.Hidden;
                    cbValues.Visibility = Visibility.Visible;
                    lbType.Content = "";
                }
                else
                {
                    tbValue.Text = "";
                    lbType.Content = string.Format(CultureInfo.InvariantCulture, Properties.Resources.TextRangeFindDialog_cbAttributes_SelectionChanged, item.Item4.Name);
                    tbValue.Visibility = Visibility.Visible;
                    cbValues.Visibility = Visibility.Hidden;
                }

                chbIgnoreCase.IsEnabled = item.Item1 == TextAttributeType.UIA_TextAttributeId;

                this.Finder = new TextRangeFinder(this.ViewModel.TextRange);
            }
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            this.Hilighter.Dispose();
            this.Hilighter = null;
        }

        /// <summary>
        /// Get value for attribute
        /// </summary>
        /// <returns></returns>
        private object GetAttributeValue()
        {
            var item = cbAttributes.SelectedItem as Tuple<int, string, dynamic, Type>;
            if(item.Item3 == null)
            {
                return ConvertToType(tbValue.Text, item.Item4);
            }
            else if (item.Item4 == typeof(bool))
            {
                return ((KeyValuePair<bool, string>)cbValues.SelectedItem).Key;
            }

            var value = (KeyValuePair<int, string >)cbValues.SelectedItem;
            return value.Key;
        }

        /// <summary>
        /// Convert text to proper type
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private static object ConvertToType(string text, Type type)
        {
            if(type == typeof(int))
            {
                return Convert.ToInt32(text,CultureInfo.InvariantCulture);
            }
            else if(type == typeof(double))
            {
                return Convert.ToDouble(text, CultureInfo.InvariantCulture);
            }
            else if(type== typeof(string))
            {
                return text;
            }

            throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, Properties.Resources.TextRangeFindDialog_ConvertToType__0__type_is_not_supported,type.Name));
        }

        /// <summary>
        /// Get the Attribute Id
        /// </summary>
        /// <returns></returns>
        private int GetAttributeId()
        {
            var item = cbAttributes.SelectedItem as Tuple<int, string, dynamic, Type>;
            return item.Item1;
        }

        /// <summary>
        /// check whether it is text search or not
        /// </summary>
        /// <returns></returns>
        private bool IsTextSearch()
        {
            var item = cbAttributes.SelectedItem as Tuple<int, string, dynamic, Type>;

            return item.Item1 == TextAttributeType.UIA_TextAttributeId;
        }

        private void btnBackward_Click(object sender, RoutedEventArgs e)
        {
            FindTextRange(true);
        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            FindTextRange(false);
        }

        /// <summary>
        /// Find TextRange via TextRangeFinder
        /// </summary>
        /// <param name="backward"></param>
        private void FindTextRange(bool backward)
        {
            //turn off hilighter
            this.Hilighter.HilightBoundingRectangles(false);

            AccessibilityInsights.Desktop.UIAutomation.Patterns.TextRange range = null;

            try
            {
                range = this.Finder.Find(GetAttributeId(), GetAttributeValue(), backward, this.chbIgnoreCase.IsChecked.Value);

                if (range != null)
                {
                    this.Hilighter.SetBoundingRectangles(range.GetBoundingRectangles());
                    this.Hilighter.HilightBoundingRectangles(true);
                }
                else
                {
                    MessageDialog.Show(Properties.Resources.TextRangeFindDialog_FindTextRange_No_matched_range_is_found);
                }
            }
            catch
            {
                MessageDialog.Show(Properties.Resources.TextRangeFindDialog_FindTextRange_Please_check_value__it_may_not_be_matched_with_expected);
            }
        }
    }
}
