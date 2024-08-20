using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("invalid_play_sessions_to_player_tracking")]
public partial class invalid_play_sessions_to_player_tracking
{
    public long ips_unique_ud { get; set; }

    public long ips_play_session_id { get; set; }

    public long ips_account_id { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal ips_coin_in { get; set; }
}
