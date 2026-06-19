1. **Apply Accessibility to `src/UniGetUI/Pages/HelpPage.xaml.cs` Buttons**
   - Add localized text to properties `AutomationProperties.SetName` and `ToolTipService.SetToolTip` to buttons on the Help Page: `BackButton`, `RightButton`, `HomeButton`, and `ReloadButton`.
   - Modify `src/UniGetUI/Pages/HelpPage.xaml.cs` to set these properties inside the constructor after `InitializeComponent()`.

2. **Complete pre-commit steps to ensure proper testing, verification, review, and reflection are done.**
   - Run the full suite using `dotnet test src/UniGetUI.Windows.slnx` with appropriate flags to ensure compilation and basic tests still pass.

3. **Verify**
   - Wait for `dotnet test` output or examine logs.

4. **Submit**
   - Submit the PR with the UX improvement context.
