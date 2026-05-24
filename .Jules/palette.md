## 2024-05-24 - Dynamic Tooltips and Accessibility Names
**Learning:** In WinUI, icon-only buttons (`<FontIcon>`, `<widgets:LocalIcon>`) do not inherit tooltips or accessible names. Relying solely on `AutomationProperties.HelpText` in XAML isn't ideal because these values need localization.
**Action:** When adding accessible names and tooltips to primary buttons, always set `AutomationProperties.SetName` and `ToolTipService.SetToolTip` dynamically in the C# code-behind using `CoreTools.Translate()` to ensure proper localization for screen readers and tooltips.
