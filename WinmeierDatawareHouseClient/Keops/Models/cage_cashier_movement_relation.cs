using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("cgm_movement_id", "cm_movement_id")]
[Table("cage_cashier_movement_relation")]
[Index("cm_movement_id", Name = "IX_cage_cashier_movement_relation_cm_movement_id")]
public partial class cage_cashier_movement_relation
{
    [Key]
    public long cgm_movement_id { get; set; }

    [Key]
    public long cm_movement_id { get; set; }
}
