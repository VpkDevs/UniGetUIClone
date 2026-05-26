## 2024-05-26 - Avoid Regex for Tabular Output Splitting
**Learning:** Using `Regex.Replace(line, @"\s+", " ")` or `Regex.Replace(line, " {2,}", " ")` before `.Split(' ')` is a common anti-pattern in the PackageEngine managers for parsing tabular CLI output. This causes unnecessary regular expression parsing overhead and memory allocations.
**Action:** Replace these calls with `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)` or `line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` to improve parsing performance significantly, especially for large CLI outputs.
