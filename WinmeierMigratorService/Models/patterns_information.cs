using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("patterns_information")]
public partial class patterns_information
{
    [Key]
    public long pti_id { get; set; }

    public int pti_state { get; set; }

    [Column(TypeName = "xml")]
    public string? pti_open_patterns { get; set; }

    public long pti_sequence { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pti_creation { get; set; }
}
