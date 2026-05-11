## 2024-05-11 - CLI Parsing Performance Bottleneck
**Learning:** The codebase heavily relied on `Regex.Replace` (e.g., `Regex.Replace(line, " {2,}", " ").Split(' ')`) to tokenize tabular CLI output from package managers, which causes significant allocation overhead in tight loops parsing thousands of lines.
**Action:** Replace `Regex.Replace` patterns with `line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` for general whitespace or `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)` for specific space separation to achieve zero-regex-allocation tokenization.
