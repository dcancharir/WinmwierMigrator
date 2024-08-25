using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("cmd_movement_id", Name = "IX_cmd_movement_id")]
public partial class cage_movement_detail
{
    [Key]
    public long cmd_cage_movement_detail_id { get; set; }

    public long cmd_movement_id { get; set; }

    public int cmd_quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal cmd_denomination { get; set; }

    [StringLength(3)]
    public string cmd_iso_code { get; set; } = null!;

    public long? cmd_chip_id { get; set; }

    public int? cmd_cage_currency_type { get; set; }
}
