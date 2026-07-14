## 2024-05-18 - Tooltips and ARIA Labels for Icon-Only Buttons
**Learning:** In WinUI, icon-only buttons need `AutomationProperties.SetName` for screen readers and `ToolTipService.SetToolTip` for sighted users to understand their purpose, especially for elements like `MegaFindButton` which is a search button without text.
**Action:** When adding accessibility to icon-only buttons, use `AutomationProperties.SetName` and `ToolTipService.SetToolTip` dynamically in the C# code-behind using `CoreTools.Translate()` to ensure proper localization.
