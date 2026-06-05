## 2023-10-27 - Dynamic Accessible Properties in Code-Behind
**Learning:** For interactive UI elements in WinUI that change visual states (like expanding/collapsing lists using icon-only buttons), accessibility properties such as `AutomationProperties.SetName` and tooltips must also be updated dynamically in the event handlers to reflect the current state to screen readers.
**Action:** When updating a control's visual state (like an icon glyph) based on an interaction, verify if its accessible name or tooltip must also be updated to ensure accurate screen reader communication.
