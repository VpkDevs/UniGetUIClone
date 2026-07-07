## 2024-03-24 - String Splitting Performance Pattern
**Learning:** Using `Regex.Replace(line, @"\s+", " ").Split(' ')` to split CLI tabular output into parts is a common performance anti-pattern in the package managers (Vcpkg, DotNet, PowerShell, WinGet). It is around 6x slower than using native `string.Split(Array.Empty<char>(), StringSplitOptions.RemoveEmptyEntries)` or `string.Split(' ', StringSplitOptions.RemoveEmptyEntries)`.
**Action:** When extracting data from CLI output tables, prefer native string splitting over regex whitespace normalization.
