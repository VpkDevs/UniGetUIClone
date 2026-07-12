## 2024-07-12 - Optimize tabular CLI tokenization
**Learning:** Using `Regex.Replace` to collapse whitespace before splitting a string (e.g., `Regex.Replace(line, @"\s+", " ").Split( )`) incurs unnecessary Regex compilation and memory allocation overhead.
**Action:** Replace `Regex.Replace` pre-processing with `line.Split(Array.Empty<char>(), StringSplitOptions.RemoveEmptyEntries)` for all whitespace or `Split( , StringSplitOptions.RemoveEmptyEntries)` for spaces to achieve zero-allocation, high-performance tokenization in CLI output parsing.
