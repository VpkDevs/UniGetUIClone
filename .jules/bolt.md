## 2024-05-18 - Avoid Regex when tokenizing CLI output
**Learning:** When tokenizing tabular CLI output separated by multiple spaces or whitespace in C#, using `string.Split(' ', StringSplitOptions.RemoveEmptyEntries)` or `string.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` avoids the Regex allocation overhead introduced by `Regex.Replace(line, " {2,}", " ")` or `Regex.Replace(line, @"\s+", " ")`, significantly improving string parsing performance.
**Action:** Use `StringSplitOptions.RemoveEmptyEntries` for tokenizing tabular spaces instead of `Regex.Replace`.
