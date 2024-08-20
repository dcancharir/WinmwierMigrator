using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("bcm_movement_id", "bcm_timestamp")]
public partial class buffer_cashier_movement
{
    [Key]
    public long bcm_movement_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime bcm_timestamp { get; set; }
}
