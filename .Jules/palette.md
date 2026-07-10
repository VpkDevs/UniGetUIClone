## 2024-05-18 - Localized Accessible Names for Icon-Only Buttons
**Learning:** WinUI `FontIcon` and `LocalIcon` elements inside icon-only buttons do not inherit accessible names or tooltips. Hardcoding `AutomationProperties.Name` in XAML breaks localization for screen readers.
**Action:** Always set `AutomationProperties.SetName` and `ToolTipService.SetToolTip` dynamically in the C# code-behind using the localized `CoreTools.Translate()` string, so icon-only buttons are both accessible and fully localized.
