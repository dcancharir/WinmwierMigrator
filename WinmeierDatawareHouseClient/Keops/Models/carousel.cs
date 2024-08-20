using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("carousel")]
public partial class carousel
{
    public long ca_carousel_id { get; set; }

    [StringLength(100)]
    public string ca_name { get; set; } = null!;

    public bool ca_enable { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ca_date_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ca_date_finish { get; set; }

    public int ca_type { get; set; }

    public int ca_schedule_weekday { get; set; }

    public int ca_schedule1_time_from { get; set; }

    public int ca_schedule1_time_to { get; set; }

    [StringLength(500)]
    public string? ca_description { get; set; }

    [Column(TypeName = "xml")]
    public string? ca_terminal_list { get; set; }

    public bool ca_audio { get; set; }
}
