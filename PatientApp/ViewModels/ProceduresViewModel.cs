using System.Collections.ObjectModel;
using PatientApp.DAL;
using PatientApp.Models;

namespace PatientApp.ViewModels;

public class ProceduresViewModel : ViewModelBase
{
    private readonly DataService _dataService = new();
    public ObservableCollection<Procedure> Procedures { get; } = new();

    public ProceduresViewModel()
    {
        Load();
    }

    public void Load()
    {
        Procedures.Clear();
        foreach (var p in _dataService.GetProcedures())
            Procedures.Add(p);
    }
}
