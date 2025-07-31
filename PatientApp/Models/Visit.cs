using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientApp.Models;

public class Visit
{
    [Key]
    public int Id { get; set; }

    [Required, ForeignKey(nameof(Patient))]
    public int PatientId { get; set; }

    public Patient Patient { get; set; } = null!;

    public DateTime VisitDate { get; set; } = DateTime.Now;

    public ICollection<VisitProcedure> VisitProcedures { get; set; } = new List<VisitProcedure>();

    public decimal? TotalCost { get; set; }
}

public class VisitProcedure
{
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Visit))]
    public int VisitId { get; set; }
    public Visit Visit { get; set; } = null!;

    [ForeignKey(nameof(Procedure))]
    public int ProcedureId { get; set; }
    public Procedure Procedure { get; set; } = null!;
}
