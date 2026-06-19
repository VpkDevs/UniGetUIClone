## 2024-03-24 - Zero-Allocation String Splitting
**Learning:** Using `Regex.Replace(line, " {2,}", " ").Split(' ')` to normalize spaces before splitting tablular CLI output is ~3.6x slower in C# than using `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)` or `line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)`.
**Action:** Always prefer `String.Split(char[], StringSplitOptions)` directly on unnormalized strings instead of regular expression replacements when tokenizing heavily padded strings in PackageEngine output parsers.
