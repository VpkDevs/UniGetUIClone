## 2024-11-20 - DataTemplate localization
**Learning:** When UI elements like icon-only buttons are inside a DataTemplate, direct code-behind modification is restricted. Instead, set accessibility properties by binding to translated properties on the underlying data model (e.g., ToolTipService.ToolTip="{x:Bind TranslatedTooltipString}" and AutomationProperties.Name="{x:Bind TranslatedTooltipString}").
**Action:** Use model-bound translated properties for accessibility inside WinUI DataTemplates.
