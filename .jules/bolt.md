
## 2024-11-20 - Avoid Regex.Replace for whitespace string splitting
**Learning:** Parsing tabular CLI outputs with `Regex.Replace(line, @"\s+", " ").Split(' ')` or `Regex.Replace(line, " {2,}", " ").Split(' ')` allocates regex objects and does multiple string passes which is inefficient in critical loops (like parsing package listings).
**Action:** Replace these patterns with `line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` (matches all whitespace) or `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)` (matches space specifically). This reduces overhead significantly by doing a single pass split without intermediate Regex strings.
