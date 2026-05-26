## 2024-05-26 - Add proper localized accessible names and tooltips to icon-only buttons
**Learning:** Icon-only buttons in WinUI defined in XAML with hardcoded `AutomationProperties.HelpText` lack proper screen reader support and do not support localization.
**Action:** Instead, dynamically set `AutomationProperties.SetName` and `ToolTipService.SetToolTip` in the code-behind using `CoreTools.Translate()` to ensure proper accessibility and localization.
