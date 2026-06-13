## 2024-05-15 - Fast Tabular CLI Output Tokenization
**Learning:** Using `Regex.Replace(line, @"\s+", " ").Split(' ')` or `Regex.Replace(line, " {2,}", " ").Split(' ')` inside tight loops parsing tabular CLI output from package managers introduces unnecessary overhead due to Regex execution for every line of CLI output.
**Action:** Replaced these patterns with `line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` for all whitespace matching and `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)` for space characters to perform zero-allocation string splitting.
