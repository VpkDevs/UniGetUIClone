## 2024-05-19 - String splitting optimization for CLI output
**Learning:** Using `Regex.Replace` to normalize spaces before `.Split(' ')` is computationally expensive and allocates unnecessary strings.
**Action:** Replace `Regex.Replace(line, @"\s+", " ").Split(' ')` with `line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` and `Regex.Replace(line, " {2,}", " ").Split(' ')` with `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)` to avoid regex overhead when parsing tabular CLI output.
