## 2024-05-24 - Zero-allocation version parsing
**Learning:** In highly called utility methods (like `VersionStringToStruct` which parses version strings repeatedly for packages), string concatenations in a loop (`string += char`) and splitting to intermediate arrays cause severe GC pressure and O(N^2) overhead.
**Action:** Replace string concatenation and allocations with direct char-by-char traversal that dynamically computes integers in place using math operations (`(long)val * 10 + (char - '0')`), yielding a 7-8x speedup. Avoid allocating string arrays or using `string.Split`.
