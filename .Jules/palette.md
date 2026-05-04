## 2024-05-04 - Accessible icon-only buttons
**Learning:** In WinUI apps, icon-only buttons need `AutomationProperties.SetName` in code-behind (or `AutomationProperties.Name` in XAML) to be read properly by screen readers, equivalent to ARIA labels. `ToolTipService.SetToolTip` should also be used to provide visual hints.
**Action:** When adding or modifying icon-only `HyperlinkButton` or `Button` elements with `FontIcon` or `SymbolIcon`, ensure both `AutomationProperties.SetName` and `ToolTipService.SetToolTip` are defined using `CoreTools.Translate()` for localized strings.
