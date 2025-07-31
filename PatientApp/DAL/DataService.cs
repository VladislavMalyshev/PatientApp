using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PatientApp.Models;

namespace PatientApp.DAL;

public class DataService
{
    public DataService()
    {
        using var db = new AppDbContext();
        db.Database.EnsureCreated();
    }

    public List<Patient> GetPatients()
    {
        using var db = new AppDbContext();
        return db.Patients.Include(p => p.Visits).ToList();
    }

    public void AddPatient(Patient patient)
    {
        using var db = new AppDbContext();
        db.Patients.Add(patient);
        db.SaveChanges();
    }

    public List<Procedure> GetProcedures()
    {
        using var db = new AppDbContext();
        return db.Procedures.ToList();
    }

    public void AddProcedure(Procedure procedure)
    {
        using var db = new AppDbContext();
        db.Procedures.Add(procedure);
        db.SaveChanges();
    }
}
