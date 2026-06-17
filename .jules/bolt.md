## 2026-06-17 - [Optimize String Parsing in CLI Output]
**Learning:** Using `Regex.Replace` to normalize multiple spaces or whitespace before calling `.Split()` is inefficient and allocates unnecessary strings/regex instances.
**Action:** Replace `Regex.Replace(line, @"\s+", " ").Split(' ')` with `line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` and `Regex.Replace(line, " {2,}", " ").Split(' ')` with `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)` to tokenize tabular CLI output efficiently without Regex overhead.
