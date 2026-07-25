## 2024-05-18 - First Learning
**Learning:** Added accessible ARIA labels for icon-only buttons.
**Action:** Verify if other icon buttons have missing ARIA names.
## 2024-05-18 - Icon-Only Button Accessibility
**Learning:** Replaced `AutomationProperties.HelpText` with `AutomationProperties.Name` on icon-only buttons (`MegaFindButton`) so screen readers announce it properly instead of ignoring it. Always pair with `ToolTipService.ToolTip`.
**Action:** When adding accessible labels to icon-only buttons, use `AutomationProperties.Name` instead of `HelpText`.
