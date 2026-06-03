## 2026-06-03 - [Regex allocation overhead]
**Learning:** Using Regex.Replace to normalize whitespaces before splitting causes unnecessary memory allocations and CPU overhead in loops.
**Action:** Use string.Split(' ', StringSplitOptions.RemoveEmptyEntries) or string.Split((char[])null, StringSplitOptions.RemoveEmptyEntries) instead.
