## 2024-05-24 - Dynamic Accessibility Properties for Icon-only Buttons
**Learning:** In WinUI, hardcoded `AutomationProperties.HelpText` or `AutomationProperties.Name` in XAML prevents dynamic localization. Icon-only buttons lack accessible names and tooltips by default.
**Action:** Always set accessibility properties (`AutomationProperties.SetName` and `ToolTipService.SetToolTip`) dynamically in the C# code-behind using `CoreTools.Translate()` when the button is initialized, and ensure `Microsoft.UI.Xaml.Automation` is imported.
