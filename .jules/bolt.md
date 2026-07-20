## 2026-07-20 - Optimize LINQ Queries
**Learning:** In C#, `.Where(...).Any()` and `.Where(...).Count()` create intermediate enumerable sequences, leading to unnecessary memory allocations and CPU overhead. These can be optimized into single passes using `.Any(...)` or `.Count(...)` respectively. String scanning is also faster with `.Contains('.')` instead of `.Where(x => x == '.').Any()`.
**Action:** Always prefer direct LINQ aggregation methods (`.Any(predicate)`, `.Count(predicate)`) over chained `.Where(predicate)` to avoid intermediate sequence generation allocations.
