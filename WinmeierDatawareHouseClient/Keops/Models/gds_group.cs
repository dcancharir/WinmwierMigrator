using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class gds_group
{
    public long gg_group_id { get; set; }

    public bool gg_group_is_explicit { get; set; }

    [StringLength(100)]
    public string gg_element_type { get; set; } = null!;

    [StringLength(100)]
    public string? gg_name { get; set; }

    public string? gg_sql_definition { get; set; }
}
