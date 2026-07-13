## 2026-07-13 - MainView dynamic tooltips
**Learning:** Hardcoded AutomationProperties.Name in XAML for icon-only buttons limits accessibility since it ignores language changes at runtime and Tooltips need to be synchronized.
**Action:** Assign AutomationProperties.SetName and ToolTipService.SetToolTip dynamically in the C# code-behind using CoreTools.Translate() and update them on state changes.
