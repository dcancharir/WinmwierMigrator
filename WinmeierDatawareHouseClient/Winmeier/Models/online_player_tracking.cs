using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("opt_type", "opt_account_id")]
[Table("online_player_tracking")]
public partial class online_player_tracking
{
    [Key]
    public int opt_type { get; set; }

    [Key]
    public long opt_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime opt_first_seen { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? opt_last_seen { get; set; }

    [StringLength(200)]
    public string? opt_data { get; set; }
}
