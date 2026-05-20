## 2024-05-13 - Initial Setup
**Learning:** Initial Palette journal created to record UX and accessibility insights for UniGetUI.
**Action:** Use this file to log critical learnings specifically for UX and a11y.

## 2024-05-13 - Enhance Accessibility for Icon-Only Buttons
**Learning:** In WinUI, using hardcoded `AutomationProperties.HelpText` in XAML for primary labels on icon-only buttons isn't fully robust, especially for screen readers and localization. Icon-only buttons do not inherently receive accessible names or tooltips from simple properties.
**Action:** Always set `AutomationProperties.SetName` and `ToolTipService.SetToolTip` dynamically in the C# code-behind using `CoreTools.Translate()` to ensure complete support for both localization and screen readers.
