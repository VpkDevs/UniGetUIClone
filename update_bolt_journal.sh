cat << 'MD' >> .jules/bolt.md
## 2024-10-24 - Avoid Regex.Replace for whitespace tokenization
**Learning:** Using `Regex.Replace(line, @"\s+", " ").Split(' ')` or `Regex.Replace(line, " {2,}", " ").Split(' ')` creates unnecessary memory allocations and is computationally slower than using `string.Split` with `StringSplitOptions.RemoveEmptyEntries`.
**Action:** Replaced `Regex.Replace(line, @"\s+", " ").Split(' ')` with `line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` for all whitespace, and `Regex.Replace(line, " {2,}", " ").Split(' ')` with `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)` for spaces.
MD
