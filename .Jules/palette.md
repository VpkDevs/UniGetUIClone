## 2026-06-03 - Localize Accessibility Labels for Icon-only buttons
**Learning:** In WinUI, hardcoded English `AutomationProperties.HelpText` strings in XAML defeat localization for screen readers.
**Action:** When adding accessible names to icon-only buttons, set them dynamically in the C# code-behind using `AutomationProperties.SetName` with `CoreTools.Translate()` during initialization.
