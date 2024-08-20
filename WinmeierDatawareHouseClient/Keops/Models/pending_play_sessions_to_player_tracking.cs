using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("pending_play_sessions_to_player_tracking")]
public partial class pending_play_sessions_to_player_tracking
{
    [Key]
    public long pps_session_id { get; set; }

    public long pps_account_id { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal pps_coin_in { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pps_datetimecreated { get; set; }

    public int pps_terminal_id { get; set; }

    public int pps_duration_total_minutes { get; set; }

    public long pps_params_numplayed { get; set; }

    public bool pps_params_balance_mismatch { get; set; }

    public int pps_terminal_type { get; set; }
}
