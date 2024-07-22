using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("service_internet_connection")]
public partial class service_internet_connection
{
    [Key]
    [StringLength(50)]
    public string sic_protocol { get; set; } = null!;

    public bool sic_has_internet_connection { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime sic_last_update { get; set; }
}
