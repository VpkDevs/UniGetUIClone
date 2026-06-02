## 2024-05-19 - Regex Allocation Overhead in Output Parsing
**Learning:** In C#, parsing tabular CLI output using `Regex.Replace(line, @"\s+", " ").Split(' ')` or `Regex.Replace(line, " {2,}", " ").Split(' ')` adds significant regex compilation and object allocation overhead per line.
**Action:** Replace these patterns with `line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` or `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)`. This avoids the regex allocation entirely and performs much faster.
