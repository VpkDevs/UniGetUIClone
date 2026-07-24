## 2024-05-24 - Accessibility improvements on icon-only buttons
**Learning:** Found several icon-only buttons in WinUI components that lack localized ARIA labels and tooltips, causing poor screen reader experiences.
**Action:** Always verify that icon-only buttons like those in list item templates or splitter controls receive both `ToolTipService.ToolTip` and `AutomationProperties.Name`, utilizing the localization framework `CoreTools.Translate`.
