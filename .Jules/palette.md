## 2024-05-30 - Localized accessibility attributes on icon-only buttons
**Learning:** In WinUI, icon-only buttons like `<FontIcon>` do not have implicit ARIA names or Tooltips. Setting `AutomationProperties.HelpText` directly in the XAML is often bad practice because it breaks localization.
**Action:** Always set `AutomationProperties.SetName` and `ToolTipService.SetToolTip` programmatically in the C# code-behind initialization (or visual state transition) using `CoreTools.Translate(...)`. Make sure `Microsoft.UI.Xaml.Automation` is available in the using block if needed.
