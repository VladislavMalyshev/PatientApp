using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PatientApp.Views;

public partial class AddPatientView : UserControl
{
    public AddPatientView()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
