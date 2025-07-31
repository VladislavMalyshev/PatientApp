using System;
using System.Reactive;
using ReactiveUI;
using PatientApp.Models;
using PatientApp.DAL;

namespace PatientApp.ViewModels;

public class AddPatientViewModel : ViewModelBase
{
    private readonly DataService _dataService = new();

    public string FullName { get; set; } = string.Empty;
    public DateTime? BirthDate { get; set; }
    public string? ContactInfo { get; set; }

    public ReactiveCommand<Unit, Unit> SaveCommand { get; }

    public AddPatientViewModel()
    {
        SaveCommand = ReactiveCommand.Create(Save);
    }

    private void Save()
    {
        var patient = new Patient
        {
            FullName = FullName,
            BirthDate = BirthDate,
            ContactInfo = ContactInfo
        };
        _dataService.AddPatient(patient);
    }
}
