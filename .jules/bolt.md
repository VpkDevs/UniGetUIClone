## 2024-05-17 - Optimize chained LINQ `.Where(predicate).Any()` and `.Where(predicate).Count()`
**Learning:** Chained LINQ methods like `.Where(predicate).Any()` and `.Where(predicate).Count()` create unnecessary intermediate `IEnumerable` allocations and iterate multiple times. Additionally, for strings, `.Where(char => char == '.').Any()` is much slower than `.Contains('.')` due to lack of internal string optimization.
**Action:** Simplify them to single-pass `.Any(predicate)` and `.Count(predicate)`. For string searches, use `.Contains(char)`.

## 2024-05-17 - Optimize chained LINQ `.Where(predicate).Any()` and `.Where(predicate).Count()`
**Learning:** Chained LINQ methods like `.Where(predicate).Any()` and `.Where(predicate).Count()` create unnecessary intermediate `IEnumerable` allocations and iterate multiple times. Additionally, for strings, `.Where(char => char == '.').Any()` is much slower than `.Contains('.')` due to lack of internal string optimization.
**Action:** Simplify them to single-pass `.Any(predicate)` and `.Count(predicate)`. For string searches, use `.Contains(char)`.
