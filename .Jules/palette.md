
## 2024-05-23 - Improve Screen Reader Accessibility for Search Button
**Learning:** WinUI requires `AutomationProperties.SetName` and `ToolTipService.SetToolTip` to be configured dynamically in C# code-behind for screen reader accessibility and localization when dealing with icon-only buttons (`AnimatedIcon`). Avoid hardcoding `AutomationProperties.HelpText` in XAML as the primary label as it cannot be easily localized and its use as a label isn't fully recommended.
**Action:** When creating or fixing icon-only buttons, verify that `AutomationProperties.SetName` and `ToolTipService.SetToolTip` are assigned localized string values via `CoreTools.Translate` during page initialization (code-behind).
