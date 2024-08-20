using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("cgm_movement_id", "cm_movement_id")]
[Table("cage_movementcashier_movement", Schema = "guest")]
public partial class cage_movementcashier_movement
{
    [Key]
    public long cgm_movement_id { get; set; }

    [Key]
    public long cm_movement_id { get; set; }
}
