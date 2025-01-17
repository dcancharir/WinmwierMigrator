using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Index("ar_name", Name = "IX_ar_name", IsUnique = true)]
[Index("ar_smoking", "ar_name", Name = "IX_ar_smoking")]
public partial class area
{
    [Key]
    public int ar_area_id { get; set; }

    [StringLength(50)]
    public string ar_name { get; set; } = null!;

    public bool ar_smoking { get; set; }

    public byte[]? ar_timestamp { get; set; }
}
