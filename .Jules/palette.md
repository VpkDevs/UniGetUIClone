## 2024-05-19 - Accessible Localized Icon Buttons
**Learning:** In WinUI apps, icon-only buttons with hardcoded `AutomationProperties.HelpText` in XAML fail to provide localized tooltips and accessible names for screen readers.
**Action:** Remove hardcoded `AutomationProperties.HelpText` from XAML. Instead, explicitly import `Microsoft.UI.Xaml.Automation` and set both `AutomationProperties.SetName` and `ToolTipService.SetToolTip` dynamically in the C# code-behind using `CoreTools.Translate()`.
