using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Automation;
using Microsoft.UI.Xaml.Controls;
using UniGetUI.Core.Tools;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace UniGetUI.Interface.Widgets;
public sealed partial class DialogCloseButton : UserControl
{
    public event EventHandler<RoutedEventArgs>? Click;

    public DialogCloseButton()
    {
        this.InitializeComponent();
        ToolTipService.SetToolTip(CloseButton, CoreTools.Translate("Close"));
        AutomationProperties.SetName(CloseButton, CoreTools.Translate("Close"));
    }

    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        Click?.Invoke(sender, e);
    }
}
