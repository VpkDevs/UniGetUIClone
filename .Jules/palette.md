## 2024-05-18 - Added accessible names and tooltips to icon-only buttons
**Learning:** Icon-only buttons do not inherit accessible names by default, and using hardcoded AutomationProperties.HelpText is discouraged. Instead, use AutomationProperties.SetName and ToolTipService.SetToolTip with translation via CoreTools.Translate() in the C# code-behind.
**Action:** Always set localized tooltips and accessible names dynamically in the code-behind using `ToolTipService` and `AutomationProperties` for icon-only buttons in WinUI.
