## 2026-07-15 - Tabular CLI output tokenization zero-allocation optimization
**Learning:** When parsing tabular CLI output separated by multiple spaces, using `Regex.Replace(line, @"\s+", " ").Split(' ')` causes unnecessary memory allocation overhead and involves the heavy Regex engine.
**Action:** Use `line.Split(Array.Empty<char>(), StringSplitOptions.RemoveEmptyEntries)` instead for faster, zero-allocation tokenization of whitespace-separated columns.
