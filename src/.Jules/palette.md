## 2026-05-31 - Dynamic Accessibility Properties for Icon-only Buttons
**Learning:** In WinUI, icon-only buttons need their tooltips and accessible names set dynamically via code-behind to support localization and screen readers correctly, rather than relying on XAML attributes.
**Action:** Set their tooltips and accessible names dynamically via code-behind using `AutomationProperties.SetName` and `ToolTipService.SetToolTip` combined with `CoreTools.Translate()` upon initialization and state changes.
