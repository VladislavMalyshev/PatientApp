using System.Collections.ObjectModel;
using ReactiveUI;
using PatientApp.Models;
using PatientApp.DAL;

namespace PatientApp.ViewModels;

public class PatientsViewModel : ViewModelBase
{
    private readonly DataService _dataService = new();

    public ObservableCollection<Patient> Patients { get; } = new();

    public PatientsViewModel()
    {
        Load();
    }

    public void Load()
    {
        Patients.Clear();
        foreach (var p in _dataService.GetPatients())
            Patients.Add(p);
    }
}
