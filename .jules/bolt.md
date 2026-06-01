## 2024-06-01 - Avoid Regex for basic whitespace splitting
**Learning:** In C#, parsing tabular CLI output separated by multiple spaces or whitespace using `Regex.Replace(line, " {2,}", " ").Split(' ')` or `Regex.Replace(line, @"\s+", " ").Split(' ')` adds unnecessary regular expression allocation overhead.
**Action:** Always prefer using `string.Split(' ', StringSplitOptions.RemoveEmptyEntries)` (for spaces) or `string.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` (for all whitespace) to significantly improve performance and avoid regular expression allocation overhead.
