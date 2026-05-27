
## 2024-06-25 - Localizing Accessibility Attributes on Icon-Only Buttons
**Learning:** In WinUI, setting `AutomationProperties.HelpText` directly in XAML for primary labels on icon-only buttons creates accessibility issues because the string is hardcoded and won't be localized by the screen reader.
**Action:** When adding accessible names and tooltips to icon-only buttons (like `ReloadButton` or `MegaFindButton`), do not hardcode `AutomationProperties.HelpText` in XAML. Instead, dynamically set both `AutomationProperties.SetName` and `ToolTipService.SetToolTip` in the C# code-behind using `CoreTools.Translate()` (and ensure `Microsoft.UI.Xaml.Automation` is imported).
