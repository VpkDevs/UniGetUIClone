## 2024-05-18 - Localized Accessibility for Icon-only Buttons
**Learning:** Hardcoding `AutomationProperties.HelpText` directly in XAML for icon-only buttons prevents proper localization, negatively impacting screen reader users and tooltip displays for non-English users.
**Action:** Always assign `AutomationProperties.SetName` (instead of HelpText) and `ToolTipService.SetToolTip` dynamically in the C# code-behind using `CoreTools.Translate()` to ensure full localization coverage for screen readers and tooltips.
