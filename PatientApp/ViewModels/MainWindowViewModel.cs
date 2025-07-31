using System.Reactive;
using ReactiveUI;

namespace PatientApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ViewModelBase CurrentView { get; private set; }

    public PatientsViewModel PatientsViewModel { get; } = new();
    public ProceduresViewModel ProceduresViewModel { get; } = new();

    public ReactiveCommand<Unit, Unit> ShowPatientsCommand { get; }
    public ReactiveCommand<Unit, Unit> ShowProceduresCommand { get; }

    public MainWindowViewModel()
    {
        CurrentView = PatientsViewModel;
        ShowPatientsCommand = ReactiveCommand.Create(() =>
        {
            CurrentView = PatientsViewModel;
        });
        ShowProceduresCommand = ReactiveCommand.Create(() =>
        {
            CurrentView = ProceduresViewModel;
        });
    }
}
