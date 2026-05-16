## 2024-05-24 - WinUI XAML Accessibility
**Learning:** In WinUI, icon-only buttons (like `FontIcon` inside a `HyperlinkButton`) do not inherit tooltips or accessible names by default. They must explicitly be assigned these properties dynamically in the C# code-behind using `AutomationProperties.SetName` and `ToolTipService.SetToolTip` with `CoreTools.Translate()` to ensure proper localization for screen readers and tooltips.
**Action:** Apply this pattern to the `ExpandCollapseOpList` and `OperationSplitterMenuButton` in `MainView.xaml.cs`.
