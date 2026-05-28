## 2026-05-28 - Whitespace tokenization optimization

**Learning:** This codebase uses `Regex.Replace(line, @"\s+", " ").Split(' ')` or `Regex.Replace(line, " {2,}", " ").Split(' ')` extensively across multiple package managers (Vcpkg, DotNet, PowerShell, Pip, Scoop, WinGet) to tokenize tabular CLI output. This introduces unnecessary regular expression compilation and execution overhead per line, negatively impacting performance when parsing thousands of lines from package manager CLI outputs.

**Action:** Replace `Regex.Replace(...).Split(' ')` with `line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)` or `line.Split(' ', StringSplitOptions.RemoveEmptyEntries)` for zero-allocation, high-performance whitespace tokenization. This prevents Regex allocation overhead and improves parsing speed across all major package manager clients.
