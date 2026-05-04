## 2024-05-24 - [Avoid String Concatenation in Loops]
**Learning:** In C#, using `+=` for string concatenation within a loop creates a new string object on every iteration, leading to O(N^2) time/space complexity and significant garbage collection pressure. This was observed in `FormatAsName` which is called thousands of times during package loading.
**Action:** Replace `+=` string concatenations in loops with a pre-allocated `char[]` buffer (when the final length is known) or a `StringBuilder` to improve performance and reduce memory allocations.
