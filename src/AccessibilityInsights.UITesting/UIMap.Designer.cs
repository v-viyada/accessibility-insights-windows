// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace AccessibilityInsights.UITests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        #region Properties
        public UIDebugWindow UIDebugWindow
        {
            get
            {
                if ((this.mUIDebugWindow == null))
                {
                    this.mUIDebugWindow = new UIDebugWindow();
                }
                return this.mUIDebugWindow;
            }
        }
        
        public UIAccessibilityInsightsWindowsStartWindow UIAccessibilityInsightsWindowsStartWindow
        {
            get
            {
                if ((this.mUIAccessibilityInsightsWindowsStartWindow == null))
                {
                    this.mUIAccessibilityInsightsWindowsStartWindow = new UIAccessibilityInsightsWindowsStartWindow();
                }
                return this.mUIAccessibilityInsightsWindowsStartWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIDebugWindow mUIDebugWindow;
        
        private UIAccessibilityInsightsWindowsStartWindow mUIAccessibilityInsightsWindowsStartWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIDebugWindow : WinWindow
    {
        
        public UIDebugWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Debug";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CabinetWClass";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIAccessibilityInsightsexeListItem UIAccessibilityInsightsexeListItem
        {
            get
            {
                if ((this.mUIAccessibilityInsightsexeListItem == null))
                {
                    this.mUIAccessibilityInsightsexeListItem = new UIAccessibilityInsightsexeListItem(this);
                }
                return this.mUIAccessibilityInsightsexeListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIAccessibilityInsightsexeListItem mUIAccessibilityInsightsexeListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIAccessibilityInsightsexeListItem : WinListItem
    {
        
        public UIAccessibilityInsightsexeListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "AccessibilityInsights.exe";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Debug");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIAccessibilityInsightsWindowsStartWindow : WpfWindow
    {
        
        public UIAccessibilityInsightsWindowsStartWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Accessibility Insights For Windows - Starting...";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Accessibility Insights For Windows - Starting...");
            this.WindowTitles.Add("Accessibility Insights For Windows - Inspect - Live");
            this.WindowTitles.Add("Accessibility Insights For Windows - Test - No selection");
            #endregion
        }
        
        #region Properties
        public WpfButton UILaterButton
        {
            get
            {
                if ((this.mUILaterButton == null))
                {
                    this.mUILaterButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUILaterButton.SearchProperties[WpfButton.PropertyNames.Name] = "Later";
                    this.mUILaterButton.WindowTitles.Add("Accessibility Insights For Windows - Starting...");
                    #endregion
                }
                return this.mUILaterButton;
            }
        }
        
        public UIWelcomepageCustom UIWelcomepageCustom
        {
            get
            {
                if ((this.mUIWelcomepageCustom == null))
                {
                    this.mUIWelcomepageCustom = new UIWelcomepageCustom(this);
                }
                return this.mUIWelcomepageCustom;
            }
        }
        
        public UINavigationBarCustom UINavigationBarCustom
        {
            get
            {
                if ((this.mUINavigationBarCustom == null))
                {
                    this.mUINavigationBarCustom = new UINavigationBarCustom(this);
                }
                return this.mUINavigationBarCustom;
            }
        }
        
        public UIContentcontainerCustom UIContentcontainerCustom
        {
            get
            {
                if ((this.mUIContentcontainerCustom == null))
                {
                    this.mUIContentcontainerCustom = new UIContentcontainerCustom(this);
                }
                return this.mUIContentcontainerCustom;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUILaterButton;
        
        private UIWelcomepageCustom mUIWelcomepageCustom;
        
        private UINavigationBarCustom mUINavigationBarCustom;
        
        private UIContentcontainerCustom mUIContentcontainerCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIWelcomepageCustom : WpfCustom
    {
        
        public UIWelcomepageCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.StartUpModeControl";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "ctrlStartUpMode";
            this.WindowTitles.Add("Accessibility Insights For Windows - Starting...");
            #endregion
        }
        
        #region Properties
        public WpfButton UIContinueButton
        {
            get
            {
                if ((this.mUIContinueButton == null))
                {
                    this.mUIContinueButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIContinueButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btnExit";
                    this.mUIContinueButton.WindowTitles.Add("Accessibility Insights For Windows - Starting...");
                    #endregion
                }
                return this.mUIContinueButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUIContinueButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UINavigationBarCustom : WpfCustom
    {
        
        public UINavigationBarCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.NamedPane";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "bdLeftNav";
            this.WindowTitles.Add("Accessibility Insights For Windows - Inspect - Live");
            this.WindowTitles.Add("Accessibility Insights For Windows - Test - No selection");
            #endregion
        }
        
        #region Properties
        public WpfButton UITestsfastpassmode2ofButton
        {
            get
            {
                if ((this.mUITestsfastpassmode2ofButton == null))
                {
                    this.mUITestsfastpassmode2ofButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUITestsfastpassmode2ofButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btnTest";
                    this.mUITestsfastpassmode2ofButton.WindowTitles.Add("Accessibility Insights For Windows - Inspect - Live");
                    #endregion
                }
                return this.mUITestsfastpassmode2ofButton;
            }
        }
        
        public WpfButton UISettings1of2Button
        {
            get
            {
                if ((this.mUISettings1of2Button == null))
                {
                    this.mUISettings1of2Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUISettings1of2Button.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btnConfig";
                    this.mUISettings1of2Button.WindowTitles.Add("Accessibility Insights For Windows - Test - No selection");
                    #endregion
                }
                return this.mUISettings1of2Button;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUITestsfastpassmode2ofButton;
        
        private WpfButton mUISettings1of2Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIContentcontainerCustom : WpfCustom
    {
        
        public UIContentcontainerCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.ConfigurationModeControl";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "ctrlConfigurationMode";
            this.WindowTitles.Add("Accessibility Insights For Windows - Test - No selection");
            #endregion
        }
        
        #region Properties
        public WpfButton UITestsettingstab3of6Button
        {
            get
            {
                if ((this.mUITestsettingstab3of6Button == null))
                {
                    this.mUITestsettingstab3of6Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUITestsettingstab3of6Button.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btnTestSettingsTab";
                    this.mUITestsettingstab3of6Button.WindowTitles.Add("Accessibility Insights For Windows - Test - No selection");
                    #endregion
                }
                return this.mUITestsettingstab3of6Button;
            }
        }
        
        public WpfButton UIWhatsnewsettingstab4Button
        {
            get
            {
                if ((this.mUIWhatsnewsettingstab4Button == null))
                {
                    this.mUIWhatsnewsettingstab4Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIWhatsnewsettingstab4Button.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btnWhatsNewTab";
                    this.mUIWhatsnewsettingstab4Button.WindowTitles.Add("Accessibility Insights For Windows - Test - No selection");
                    #endregion
                }
                return this.mUIWhatsnewsettingstab4Button;
            }
        }
        
        public WpfButton UIAbouttab5of6Button
        {
            get
            {
                if ((this.mUIAbouttab5of6Button == null))
                {
                    this.mUIAbouttab5of6Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIAbouttab5of6Button.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btnAboutTab";
                    this.mUIAbouttab5of6Button.WindowTitles.Add("Accessibility Insights For Windows - Test - No selection");
                    #endregion
                }
                return this.mUIAbouttab5of6Button;
            }
        }
        
        public WpfButton UIFeedbacksettingstab6Button
        {
            get
            {
                if ((this.mUIFeedbacksettingstab6Button == null))
                {
                    this.mUIFeedbacksettingstab6Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIFeedbacksettingstab6Button.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btnFeedbackTab";
                    this.mUIFeedbacksettingstab6Button.WindowTitles.Add("Accessibility Insights For Windows - Test - No selection");
                    #endregion
                }
                return this.mUIFeedbacksettingstab6Button;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUITestsettingstab3of6Button;
        
        private WpfButton mUIWhatsnewsettingstab4Button;
        
        private WpfButton mUIAbouttab5of6Button;
        
        private WpfButton mUIFeedbacksettingstab6Button;
        #endregion
    }
}
