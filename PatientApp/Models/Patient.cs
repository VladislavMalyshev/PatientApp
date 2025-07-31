using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatientApp.Models;

public class Patient
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string FullName { get; set; } = string.Empty;

    public DateTime? BirthDate { get; set; }

    public string? ContactInfo { get; set; }

    public ICollection<Visit> Visits { get; set; } = new List<Visit>();
}
