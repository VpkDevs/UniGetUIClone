using Microsoft.UI.Xaml.Automation;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
using UniGetUI.Core.Tools;
using UniGetUI.Interface.Pages.AboutPages;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace UniGetUI.Interface
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AboutUniGetUI : Page
    {
        public event EventHandler? Close;
        private int previousSelectedIndex;

        public AboutUniGetUI()
        {
            InitializeComponent();

            string aboutText = CoreTools.Translate("About");
            SelectorBarItemPage1.Text = aboutText;
            AutomationProperties.SetName(SelectorBarItemPage1, aboutText);
            ToolTipService.SetToolTip(SelectorBarItemPage1, aboutText);

            string licensesText = CoreTools.Translate("Third-party licenses");
            SelectorBarItemPage2.Text = licensesText;
            AutomationProperties.SetName(SelectorBarItemPage2, licensesText);
            ToolTipService.SetToolTip(SelectorBarItemPage2, licensesText);

            string contributorsText = CoreTools.Translate("Contributors");
            SelectorBarItemPage3.Text = contributorsText;
            AutomationProperties.SetName(SelectorBarItemPage3, contributorsText);
            ToolTipService.SetToolTip(SelectorBarItemPage3, contributorsText);

            string translatorsText = CoreTools.Translate("Translators");
            SelectorBarItemPage4.Text = translatorsText;
            AutomationProperties.SetName(SelectorBarItemPage4, translatorsText);
            ToolTipService.SetToolTip(SelectorBarItemPage4, translatorsText);
        }

        private void SelectorBar_SelectionChanged(
            SelectorBar sender,
            SelectorBarSelectionChangedEventArgs args
        )
        {
            SelectorBarItem selectedItem = sender.SelectedItem;
            int currentSelectedIndex = sender.Items.IndexOf(selectedItem);
            Type pageType = currentSelectedIndex switch
            {
                0 => typeof(Pages.AboutPages.AboutUniGetUI),
                1 => typeof(ThirdPartyLicenses),
                2 => typeof(Contributors),
                _ => typeof(Translators),
            };
            SlideNavigationTransitionEffect slideNavigationTransitionEffect =
                currentSelectedIndex - previousSelectedIndex > 0
                    ? SlideNavigationTransitionEffect.FromRight
                    : SlideNavigationTransitionEffect.FromLeft;

            ContentFrame.Navigate(
                pageType,
                null,
                new SlideNavigationTransitionInfo { Effect = slideNavigationTransitionEffect }
            );

            previousSelectedIndex = currentSelectedIndex;
        }

        private void CloseButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            Close?.Invoke(this, EventArgs.Empty);
        }
    }
}
