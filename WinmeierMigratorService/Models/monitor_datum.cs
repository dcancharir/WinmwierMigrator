using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class monitor_datum
{
    [Key]
    public long md_unique_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime md_datetime { get; set; }

    public int md_type { get; set; }

    [Column(TypeName = "xml")]
    public string md_data { get; set; } = null!;

    [Column(TypeName = "xml")]
    public string md_schema { get; set; } = null!;
}
