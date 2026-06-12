## 2024-05-24 - Localizing WinUI AutomationProperties
**Learning:** When using WinUI XAML for elements like icon-only buttons (e.g. `<FontIcon>` or Segmented items), hardcoding `AutomationProperties.Name` or `ToolTipService.ToolTip` directly in the XAML markup prevents proper localization for screen readers and tooltips.
**Action:** Instead, dynamically assign these properties in the C# code-behind using `ToolTipService.SetToolTip(Element, CoreTools.Translate("Text"));` and `AutomationProperties.SetName(Element, CoreTools.Translate("Text"));`. This ensures full support for localization.
