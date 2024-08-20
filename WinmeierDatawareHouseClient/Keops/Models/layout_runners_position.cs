using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("lrp_user_id", "lrp_device_id")]
[Table("layout_runners_position")]
public partial class layout_runners_position
{
    [Key]
    public long lrp_user_id { get; set; }

    [Key]
    [StringLength(50)]
    public string lrp_device_id { get; set; } = null!;

    [StringLength(50)]
    public string lrp_floor_id { get; set; } = null!;

    public double? lrp_x { get; set; }

    public double? lrp_y { get; set; }

    public double? lrp_range { get; set; }

    [StringLength(50)]
    public string? lrp_near_beacon { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lrp_last_update { get; set; }
}
