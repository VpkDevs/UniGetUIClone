## 2024-05-18 - Avoid Regex.Replace for simple string splitting
**Learning:** Using `Regex.Replace(line, @"\s+", " ").Split(' ')` or `Regex.Replace(line, " {2,}", " ").Split(' ')` to split a tabular CLI output by spaces is computationally expensive and allocates unnecessary intermediate strings.
**Action:** Replace `Regex.Replace` followed by `Split(' ')` with `string.Split(' ', StringSplitOptions.RemoveEmptyEntries)` or `string.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` for zero-allocation whitespace handling when tokenizing strings.
