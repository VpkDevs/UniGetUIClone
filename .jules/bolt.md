## 2024-12-05 - Avoid Regex for basic string splitting
**Learning:** Performance memory highlights that replacing `Regex.Replace(line, @"\s+", " ")` with `line.Split(Array.Empty<char>(), StringSplitOptions.RemoveEmptyEntries)` is vastly more efficient for string processing as it skips intermediate strings and expensive regex matching.
**Action:** Replace Regex usage with `StringSplitOptions.RemoveEmptyEntries` in package managers output parsing.
