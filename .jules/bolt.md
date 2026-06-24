## 2024-11-09 - [Tokenizing CLI output without Regex]
**Learning:** Using `Regex.Replace(line, @"\s+", " ").Split(' ')` or `Regex.Replace(line, " {2,}", " ").Split(' ')` for tokenizing tabular CLI output causes unnecessary performance overhead and memory allocations due to regex compilation and string manipulation.
**Action:** Always prefer `string.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries)` for general whitespace or `string.Split(' ', StringSplitOptions.RemoveEmptyEntries)` for spaces to drastically reduce memory allocation and improve performance.
