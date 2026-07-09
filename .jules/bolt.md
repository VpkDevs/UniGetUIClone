## 2024-07-09 - Zero-allocation version parsing
**Learning:** `VersionStringToStruct` used `string.Split`, string concatenation `+=` within a loop, and `int.TryParse`, leading to many allocations and high CPU time for an operation called frequently.
**Action:** Replaced string array concatenations and `string.Split` with direct `char` traversal and in-place `long` mathematical integer parsing, matching `int.TryParse` behavior on overflows.
