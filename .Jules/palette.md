## 2024-05-22 - MainView Splitter Menu Button Accessibility
**Learning:** Found a missing tooltip on `OperationSplitterMenuButton` which uses an icon-only `HyperlinkButton`. Icon-only buttons need tooltip text and an accessible name (AutomationProperties.SetName).
**Action:** Adding translation and automation name for the operation splitter menu button in the code-behind to support screen readers and tooltips.
