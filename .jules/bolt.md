## YYYY-MM-DD - Initializing Journal
**Learning:** Initializing journal for Bolt to record critical learnings about performance optimizations in this codebase.
**Action:** Use this journal to document codebase-specific insights.

## 2025-02-12 - Regex.Replace to String.Split Optimization
**Learning:** In C#, processing tabular CLI output (like `vcpkg`, `dotnet`, `powershell`, `scoop`, `winget`) using `Regex.Replace(line, " {2,}", " ").Split(' ')` or `Regex.Replace(line, @"\s+", " ").Split(' ')` is computationally expensive and allocates unnecessary memory. `string.Split(' ', StringSplitOptions.RemoveEmptyEntries)` or `string.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries)` is drastically faster (up to ~8x faster) and avoids `Regex` overhead.
**Action:** Replaced uses of `Regex.Replace` with appropriate `string.Split` configurations in package manager parsers.
