## 2026-07-21 - Dynamic Accessibility for Stateful Icon Buttons
**Learning:** When a UI element like a toggle button changes visual state (e.g., FontIcon changing from expand to collapse), static XAML accessibility properties are insufficient.
**Action:** Always bind or update both 'AutomationProperties.SetName' and 'ToolTipService.SetToolTip' dynamically in the code-behind event handler to accurately reflect the current state to screen readers and tooltips.
