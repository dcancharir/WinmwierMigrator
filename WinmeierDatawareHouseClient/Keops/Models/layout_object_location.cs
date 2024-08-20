using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("lol_object_id", "lol_location_id", "lol_date_from")]
public partial class layout_object_location
{
    [Key]
    public long lol_object_id { get; set; }

    [Key]
    public long lol_location_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime lol_date_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lol_date_to { get; set; }

    public int? lol_orientation { get; set; }

    public int? lol_area_id { get; set; }

    public int? lol_bank_id { get; set; }

    public int? lol_bank_location { get; set; }

    public bool lol_current_location { get; set; }

    public double lol_offset_x { get; set; }

    public double lol_offset_y { get; set; }
}
