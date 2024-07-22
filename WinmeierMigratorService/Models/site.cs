using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("site")]
public partial class site
{
    [Key]
    public Guid st_id { get; set; }

    [StringLength(50)]
    public string st_name { get; set; } = null!;

    [StringLength(255)]
    public string? st_inhouse_api_url { get; set; }
}
