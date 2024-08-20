using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_range
{
    public int lr_id { get; set; }

    [StringLength(100)]
    public string lr_name { get; set; } = null!;

    [StringLength(500)]
    public string lr_field { get; set; } = null!;

    public int lr_section_id { get; set; }

    public int lr_role { get; set; }

    public string? lr_icon { get; set; }

    public int lr_view { get; set; }

    public int? lr_nls { get; set; }

    [StringLength(200)]
    public string? lr_external_nls { get; set; }

    public bool? lr_editable { get; set; }

    public bool? lr_visible { get; set; }

    public bool? lr_has_unknown_values { get; set; }
}
