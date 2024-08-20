using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class gt_play_session
{
    public long gtps_play_session_id { get; set; }

    public int gtps_gaming_table_id { get; set; }

    public long gtps_gaming_table_session_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gtps_started { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gtps_finished { get; set; }

    public long gtps_account_id { get; set; }

    public long gtps_seat_id { get; set; }

    public int gtps_status { get; set; }

    public long? gtps_plays { get; set; }

    [Column(TypeName = "money")]
    public decimal gtps_current_bet { get; set; }

    [Column(TypeName = "money")]
    public decimal gtps_bet_min { get; set; }

    [Column(TypeName = "money")]
    public decimal gtps_bet_max { get; set; }

    [Column(TypeName = "money")]
    public decimal gtps_played_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtps_played_average { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtps_points { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtps_computed_points { get; set; }

    public long? gtps_game_time { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gtps_start_walk { get; set; }

    public long? gtps_walk { get; set; }

    public int? gtps_player_skill { get; set; }

    public int? gtps_player_speed { get; set; }

    public int? gtps_finished_user_id { get; set; }

    public int? gtps_updated_user_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtps_total_sell_chips { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtps_chips_out { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtps_chips_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtps_netwin { get; set; }

    public long? gtps_in_session_plays_table { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtps_in_session_last_played_amount { get; set; }

    public long? gtps_in_session_last_play { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gtps_updated_played_current { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gtps_updated { get; set; }

    public byte[] gtps_timestamp { get; set; } = null!;

    public long? gtps_import_operation_id { get; set; }

    [StringLength(6)]
    public string gtps_iso_code { get; set; } = null!;

    public bool gtps_auto_action { get; set; }

    public int gtps_counter_update_bet { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtps_theo_win { get; set; }

    public long? gtps_original_account { get; set; }
}
