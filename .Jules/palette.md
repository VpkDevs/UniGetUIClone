## 2024-05-21 - Localized Accessibility for WinUI Icon Buttons
**Learning:** Icon-only buttons in WinUI do not automatically inherit tooltips or accessible names. Furthermore, setting `AutomationProperties.HelpText` or `AutomationProperties.Name` in XAML prevents proper localization.
**Action:** When adding or updating icon-only buttons in WinUI, always set `AutomationProperties.SetName` and `ToolTipService.SetToolTip` dynamically in the C# code-behind using `CoreTools.Translate()` to ensure both screen readers and tooltips are localized.
