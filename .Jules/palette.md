## 2026-07-17 - Dynamic Accessibility Properties
**Learning:** Icon-only buttons with changing states must update their tooltips and accessible names dynamically in C# code-behind rather than relying on hardcoded XAML.
**Action:** Add ToolTipService.SetToolTip and AutomationProperties.SetName to the constructor and the event handler.
