## 2024-05-24 - Zero-Allocation Whitespace Tokenization
**Learning:** Parsing tabular CLI output using `Regex.Replace(line, " {2,}", " ").Split(' ')` or `Regex.Replace(line, @"\s+", " ")` incurs significant performance overhead due to regex allocation, compilation, and execution per line.
**Action:** Always prefer using `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)` or `line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` directly on strings when tokenizing tabular output separated by spaces or whitespace to avoid regex allocation.
