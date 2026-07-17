## 2024-11-20 - Zero-Allocation Whitespace Splitting
**Learning:** `Regex.Replace(line, @"\s+", " ").Split(' ')` or `Regex.Replace(line, " {2,}", " ").Split(' ')` creates heavy memory allocation overhead via Regex instantiation, intermediate strings, and string arrays for simple tabular parsing.
**Action:** Always prefer `line.Split(Array.Empty<char>(), StringSplitOptions.RemoveEmptyEntries)` for zero-allocation tabular/whitespace splitting in high-throughput package output parsing.
