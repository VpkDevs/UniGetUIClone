1. **Optimize `InstallOptions.cs`**
    - Replace `.Where(x => x.Any()).Any()` with `.Any(x => x.Any())` in lines 286, 320, and 368.

2. **Optimize `AppOperationHelper.cs`**
    - Replace `.Where(x => x == '.').Any()` with `.Contains('.')` in line 111.

3. **Optimize `AbstractPackagesPage.xaml.cs`**
    - Replace `.Where(w => w.Package.Equals(package)).Any()` with `.Any(w => w.Package.Equals(package))` in line 487.
    - Replace `.Where(p => p.IsChecked).Count()` with `.Count(p => p.IsChecked)` in line 1067.
    - Replace `.Where(p => !p.IsChecked).Count()` with `.Count(p => !p.IsChecked)` in line 1068.

4. **Optimize `PackageBundlesPage.cs`**
    - Replace `.Where(x => x.Any()).Any()` with `.Any(x => x.Any())` in lines 694, 710, and 726.

5. **Build and test the solution**
    - Run `dotnet build src/UniGetUI.Windows.slnx -p:EnableWindowsTargeting=true -p:Platform=x64`
    - Run `dotnet test src/UniGetUI.Windows.slnx -p:EnableWindowsTargeting=true -p:Platform=x64`

6. **Complete pre-commit steps**
    - Complete pre-commit steps to ensure proper testing, verification, review, and reflection are done.

7. **Submit PR**
    - Create a PR titled "⚡ Bolt: [performance improvement] Simplify LINQ chains for zero-allocation" with impact details.
