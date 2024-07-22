using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("gps_play_session_id", "gps_game_id")]
public partial class game_play_session
{
    [Key]
    public long gps_play_session_id { get; set; }

    [Key]
    public int gps_game_id { get; set; }

    public long gps_account_id { get; set; }

    public int gps_terminal_id { get; set; }

    public int? gps_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? gps_played_amount { get; set; }

    public int? gps_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? gps_won_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gps_payout { get; set; }
}
