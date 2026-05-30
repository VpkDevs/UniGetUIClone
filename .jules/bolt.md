## 2024-06-21 - [String Split Optimization]
**Learning:** Using `string.Split(' ', StringSplitOptions.RemoveEmptyEntries)` is significantly faster than using `Regex.Replace(line, " {2,}", " ").Split(' ')` for tokenizing tabular CLI output. It avoids regex compilation and allocation overhead, especially since package managers output lots of tabular data.
**Action:** Next time tokenizing space-separated tabular data, prefer `StringSplitOptions.RemoveEmptyEntries` over regex replacements.
