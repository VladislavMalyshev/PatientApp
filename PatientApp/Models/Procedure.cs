using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatientApp.Models;

public class Procedure
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal Cost { get; set; }

    public ICollection<VisitProcedure> VisitProcedures { get; set; } = new List<VisitProcedure>();
}
