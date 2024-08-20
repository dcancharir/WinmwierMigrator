using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_ranges_legend
{
    public int lrl_id { get; set; }

    public int lrl_range_id { get; set; }

    [StringLength(100)]
    public string lrl_label { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal lrl_value1 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? lrl_value2 { get; set; }

    [StringLength(20)]
    public string lrl_operator { get; set; } = null!;

    [StringLength(20)]
    public string lrl_color { get; set; } = null!;

    [StringLength(500)]
    public string? lrl_field { get; set; }

    public bool? lrl_editable { get; set; }

    public int lrl_auto_assign_role { get; set; }

    public int lrl_auto_assign_priority { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? lrl_external_nls { get; set; }
}
