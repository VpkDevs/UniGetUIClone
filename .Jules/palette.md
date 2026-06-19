## 2024-06-19 - Dynamically Localized ARIA Labels for Icon-Only Buttons
**Learning:** In WinUI, icon-only buttons (like those using `FontIcon` or `SymbolIcon`) do not inherit tooltips or accessible names by default. Hardcoding `AutomationProperties.Name` in XAML creates localization gaps.
**Action:** Always dynamically set `AutomationProperties.SetName` and `ToolTipService.SetToolTip` using `CoreTools.Translate()` in the C# code-behind (e.g., inside the constructor after `InitializeComponent()`) for icon-only buttons to ensure they are fully accessible and localized.
