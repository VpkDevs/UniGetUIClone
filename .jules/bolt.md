## 2024-06-25 - Tokenizing tabular CLI output
**Learning:** In C#, replacing `Regex.Replace(line, " {2,}", " ").Split(' ')` with `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)` is ~4x faster and avoids string allocation overhead when parsing tabular CLI output separated by multiple spaces.
**Action:** Use `string.Split(' ', StringSplitOptions.RemoveEmptyEntries)` instead of pre-processing the string with regular expressions for tabular output tokenization.
