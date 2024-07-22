using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
[Table("h_meters_definition")]
public partial class h_meters_definition
{
    public int hmd_meter_id { get; set; }

    public int hmd_meter_item { get; set; }

    public int hmd_meter_type { get; set; }

    [StringLength(250)]
    public string? hmd_description { get; set; }

    public int hmd_meter_mask { get; set; }

    public bool hmd_meter_enabled { get; set; }

    public int hmd_meter_last_update { get; set; }

    public int hmd_meter_device { get; set; }

    public bool hmd_visible { get; set; }

    [StringLength(200)]
    public string? hmd_stored_name { get; set; }

    [StringLength(100)]
    public string? hmd_meter_name { get; set; }
}
