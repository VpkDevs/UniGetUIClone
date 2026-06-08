## 2024-05-16 - Localized Accessibility for Icon-only Buttons
**Learning:** Hardcoding `AutomationProperties.HelpText` in WinUI XAML for primary labels on icon-only buttons limits localization capabilities.
**Action:** Always set `AutomationProperties.SetName` and `ToolTipService.SetToolTip` dynamically in the C# code-behind using `CoreTools.Translate()` to ensure proper localization for screen readers and tooltips.
