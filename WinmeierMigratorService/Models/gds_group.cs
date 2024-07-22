using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class gds_group
{
    [Key]
    public long gg_group_id { get; set; }

    /// <summary>
    /// 0 - Group defined through SQL definition; 1 - Group defined by explicit assignment
    /// </summary>
    public bool gg_group_is_explicit { get; set; }

    [StringLength(50)]
    public string gg_element_type { get; set; } = null!;

    [StringLength(50)]
    public string? gg_name { get; set; }

    public string? gg_sql_definition { get; set; }
}
