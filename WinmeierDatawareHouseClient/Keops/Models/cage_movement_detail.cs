using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class cage_movement_detail
{
    public long cmd_cage_movement_detail_id { get; set; }

    public long cmd_movement_id { get; set; }

    public int cmd_quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal cmd_denomination { get; set; }

    [StringLength(6)]
    public string cmd_iso_code { get; set; } = null!;

    public long? cmd_chip_id { get; set; }

    public int? cmd_cage_currency_type { get; set; }
}
