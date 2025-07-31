using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PatientApp.Views;

public partial class PatientsView : UserControl
{
    public PatientsView()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
