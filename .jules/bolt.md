## 2024-05-23 - [Optimizing tabular CLI output parsing]
**Learning:** In C#, parsing tabular CLI output separated by multiple spaces or whitespace using `Regex.Replace(line, " {2,}", " ").Split(' ')` or `Regex.Replace(line, @"\s+", " ").Split(' ')` is a performance anti-pattern that causes unnecessary regular expression allocation overhead.
**Action:** Use `string.Split(' ', StringSplitOptions.RemoveEmptyEntries)` or `string.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` directly instead to significantly improve parsing performance.
