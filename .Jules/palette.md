## 2026-06-30 - Dynamic Accessibility Properties for Icon-only Buttons
**Learning:** In WinUI, icon-only buttons do not inherit tooltips or accessible names. To support screen readers and localization, these properties must be set dynamically in the C# code-behind using `AutomationProperties.SetName` and `ToolTipService.SetToolTip` combined with `CoreTools.Translate()` upon control initialization, requiring `Microsoft.UI.Xaml.Automation` import.
**Action:** Always add programmatic a11y labels and tooltips in the code-behind constructor for icon-only buttons in WinUI components.
