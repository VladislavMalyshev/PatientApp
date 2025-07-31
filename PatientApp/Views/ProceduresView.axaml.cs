using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PatientApp.Views;

public partial class ProceduresView : UserControl
{
    public ProceduresView()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
