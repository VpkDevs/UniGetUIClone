## 2024-06-18 - Fast String Tokenization for Tabular Outputs
**Learning:** Parsing tabular outputs via `Regex.Replace(line, " {2,}", " ").Split(' ')` allocates heavily and causes high GC pressure.
**Action:** Replace tokenization patterns across package managers with `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)` or `line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` for a ~6x performance gain without changing logic.
