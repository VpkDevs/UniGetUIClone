## 2024-05-15 - WinUI Icon-only Buttons
**Learning:** In WinUI XAML applications, icon-only buttons (using `FontIcon` or `LocalIcon`) need both `AutomationProperties.Name` for screen readers (equivalent to ARIA labels) and `ToolTipService.ToolTip` for sighted mouse users. They are frequently missing in utility dialogs.
**Action:** Always check `Button` elements in XAML that contain only an icon element. Add both properties using clear, descriptive action phrases.
