using Microsoft.EntityFrameworkCore;
using PatientApp.Models;
using System;
using System.IO;

namespace PatientApp.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Patient> Patients => Set<Patient>();
    public DbSet<Procedure> Procedures => Set<Procedure>();
    public DbSet<Visit> Visits => Set<Visit>();
    public DbSet<VisitProcedure> VisitProcedures => Set<VisitProcedure>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var path = Path.Combine(System.AppContext.BaseDirectory, "patientapp.db");
        optionsBuilder.UseSqlite($"Data Source={path}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
