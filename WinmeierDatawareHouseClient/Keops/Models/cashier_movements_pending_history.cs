using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("cmph_movement_id", "cmph_sub_type")]
[Table("cashier_movements_pending_history")]
public partial class cashier_movements_pending_history
{
    [Key]
    public long cmph_movement_id { get; set; }

    [Key]
    public int cmph_sub_type { get; set; }
}
