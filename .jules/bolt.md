## 2024-05-10 - Replace Regex string split with fast split
**Learning:** Parsing tabular package manager output with `Regex.Replace(line, " {2,}", " ").Split(' ')` creates huge GC allocations and CPU overhead in tight loops.
**Action:** Use `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)` or `line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` when stripping multiple whitespaces during package output parsing.
