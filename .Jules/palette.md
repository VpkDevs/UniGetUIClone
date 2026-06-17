## 2026-06-17 - Dynamic Accessibility for Icon-only Buttons
**Learning:** Icon-only buttons in WinUI require ToolTipService.SetToolTip and AutomationProperties.SetName to be dynamically set via C# code-behind with CoreTools.Translate() instead of hardcoding AutomationProperties.HelpText in XAML.
**Action:** Always set tooltips and accessible names programmatically for icon buttons to ensure proper localization and screen reader support.
