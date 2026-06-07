## 2024-05-24 - Dynamic localized accessibility for icon-only buttons
**Learning:** Hardcoding `AutomationProperties.HelpText` in WinUI XAML prevents proper localization. Icon-only buttons need explicit names and tooltips.
**Action:** Always set `AutomationProperties.SetName` and `ToolTipService.SetToolTip` programmatically in the code-behind using `CoreTools.Translate()` upon control initialization to ensure localization works for both screen readers and visual tooltips.
