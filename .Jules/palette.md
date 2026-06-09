## 2024-06-09 - Localized Accessible Names for Icon Buttons
**Learning:** Hardcoded `AutomationProperties.HelpText` or `AutomationProperties.Name` in XAML for primary labels on icon-only buttons prevents localization and limits accessibility for international users.
**Action:** Set `AutomationProperties.SetName` and `ToolTipService.SetToolTip` dynamically in the C# code-behind using `CoreTools.Translate()` upon control initialization to ensure proper localization for screen readers and tooltips.
