## 2026-07-02 - Zero Allocation Version Parsing
**Learning:** Parsing versions by splitting arrays and trying to parse strings creates excessive allocations and is 3-4x slower. Single-pass string character iteration completely removes allocations for parsing.
**Action:** Use char iteration and math for simple structural parsing.
