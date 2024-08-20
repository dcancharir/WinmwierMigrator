using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("occupancy_sensor")]
public partial class occupancy_sensor
{
    public int ose_id { get; set; }

    public int ose_type { get; set; }

    [StringLength(100)]
    public string ose_hostname { get; set; } = null!;

    [StringLength(100)]
    public string ose_alias { get; set; } = null!;

    public int ose_meter_mode { get; set; }

    public long? ose_meter_in { get; set; }

    public long? ose_meter_out { get; set; }

    public long ose_delta_in { get; set; }

    public long ose_delta_out { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ose_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ose_meter_updated { get; set; }
}
