using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_device
{
    public long ld_id { get; set; }

    [StringLength(100)]
    public string ld_device_id { get; set; } = null!;

    public long ld_user_id { get; set; }

    public int? ld_type { get; set; }

    [StringLength(500)]
    public string? ld_model { get; set; }

    public bool? ld_enabled { get; set; }

    public int? ld_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ld_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ld_last_update { get; set; }

    [StringLength(100)]
    public string? ld_device_name { get; set; }
}
