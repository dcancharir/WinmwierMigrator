using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("x2d_date", "x2d_meter_type")]
[Table("h_x2d_control")]
public partial class h_x2d_control
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime x2d_date { get; set; }

    [Key]
    public int x2d_meter_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? x2d_execution { get; set; }
}
