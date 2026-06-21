
## 2024-05-18 - Avoid Regex.Replace for Whitespace Tokenization
**Learning:** Using `Regex.Replace(line, @"\s+", " ").Split(' ')` or `Regex.Replace(line, " {2,}", " ").Split(' ')` to tokenize tabular CLI output on whitespace is an anti-pattern. It introduces unnecessary Regex overhead and intermediate allocations for operations that can be performed natively by `string.Split()`.
**Action:** When splitting text by arbitrary amounts of whitespace, use `line.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries)`. When splitting by single spaces where multiple spaces might exist, use `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)`.
