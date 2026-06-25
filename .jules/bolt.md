## 2024-05-23 - Avoid Regex.Replace for Tabular CLI Output Tokenization
**Learning:** The codebase frequently uses `Regex.Replace(line, @"\s+", " ").Split(' ')` to tokenize tabular CLI output. This is a performance anti-pattern as it allocates strings unnecessarily and runs a slow regex parser per line in loops.
**Action:** Use `string.Split(' ', StringSplitOptions.RemoveEmptyEntries)` for spaces or `string.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries)` for all whitespace to achieve zero-allocation splitting without Regex overhead.
