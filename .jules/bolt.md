## 2024-05-24 - Zero-allocation Version parsing optimization

**Learning:** When trying to eliminate string allocations in version parsing (`VersionStringToStruct`), I discovered that manually re-implementing `int.TryParse` with simple loop arithmetic (`val * 10 + char`) doesn't naturally handle integer overflows the same way. The original `int.TryParse` on a massively long segment (like `9999999999999`) gracefully fails and returns `0` via its `out` parameter. My naive math wrapped around into negative space, which would have corrupted version sorting on obscure edge cases.

**Action:** Always verify the edge-case behavior (like overflow constraints) of native .NET methods like `int.TryParse` before manually inlining them. In this case, using a `long[]` buffer array during parsing to safely detect bounding past `int.MaxValue` before clamping back to `0` solved the compatibility issue perfectly while preserving the zero-allocation performance benefit.
