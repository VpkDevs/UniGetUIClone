
## 2024-05-18 - Dynamic Tooltips for Icon-Only Buttons in WinUI 3
**Learning:** In WinUI 3, hardcoding string values in XAML for accessibility properties (like `AutomationProperties.Name` and tooltips) on icon-only buttons means they will not be properly localized through the application's translation framework or dynamic state.
**Action:** Always prefer assigning screen reader names via `AutomationProperties.SetName()` and tooltips via `ToolTipService.SetToolTip()` within the C# code-behind dynamically (e.g., using `CoreTools.Translate()`) during control initialization and state changes, rather than hardcoding static properties directly in the XAML UI.
