using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Index("ar_name", Name = "IX_ar_name", IsUnique = true)]
[Index("ar_smoking", "ar_name", Name = "IX_ar_smoking")]
[Index("ar_venue_id", Name = "IX_areas_ar_venue_id")]
public partial class area
{
    [Key]
    public int ar_area_id { get; set; }

    [StringLength(50)]
    public string ar_name { get; set; } = null!;

    public bool ar_smoking { get; set; }

    public byte[]? ar_timestamp { get; set; }

    public int ar_venue_id { get; set; }

    [StringLength(4)]
    public string ar_external_id { get; set; } = null!;
}
