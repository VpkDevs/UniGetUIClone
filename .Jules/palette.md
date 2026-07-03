## 2024-07-03 - Dynamic Accessibility in WinUI
**Learning:** In WinUI, accessibility properties like `AutomationProperties.Name` and `ToolTipService.ToolTip` for icon-only buttons should be set dynamically in the C# code-behind using `CoreTools.Translate()` to ensure proper localization for screen readers and tooltips, rather than hardcoding them in the XAML.
**Action:** Always add dynamic translated properties in the component constructor for icon-only buttons, and ensure `using Microsoft.UI.Xaml.Automation;` is imported.
