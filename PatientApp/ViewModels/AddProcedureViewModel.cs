using System.Reactive;
using ReactiveUI;
using PatientApp.DAL;
using PatientApp.Models;

namespace PatientApp.ViewModels;

public class AddProcedureViewModel : ViewModelBase
{
    private readonly DataService _dataService = new();

    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Cost { get; set; }

    public ReactiveCommand<Unit, Unit> SaveCommand { get; }

    public AddProcedureViewModel()
    {
        SaveCommand = ReactiveCommand.Create(Save);
    }

    private void Save()
    {
        var proc = new Procedure
        {
            Name = Name,
            Description = Description,
            Cost = Cost
        };
        _dataService.AddProcedure(proc);
    }
}
