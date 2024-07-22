using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("operations_schedule_status")]
public partial class operations_schedule_status
{
    [Key]
    public int oss_type { get; set; }

    public bool oss_allowed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime oss_last_updated { get; set; }
}
