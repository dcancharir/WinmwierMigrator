using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_location
{
    public long loc_id { get; set; }

    public double loc_x { get; set; }

    public double loc_y { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime loc_creation { get; set; }

    public int loc_type { get; set; }

    public int loc_floor_number { get; set; }

    [StringLength(100)]
    public string? loc_grid_id { get; set; }

    public int loc_status { get; set; }
}
