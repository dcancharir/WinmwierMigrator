using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("gtps_finished", "gtps_account_id", Name = "IX_gtps_account_id_finished")]
[Index("gtps_started", "gtps_account_id", Name = "IX_gtps_account_id_started")]
[Index("gtps_finished", "gtps_status", Name = "IX_gtps_finished_status")]
[Index("gtps_started", "gtps_status", Name = "IX_gtps_started_status")]
[Index("gtps_timestamp", Name = "IX_gtps_timestamp")]
public partial class gt_play_session
{
    [Key]
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

    public int gtps_plays { get; set; }

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

    public int? gtps_in_session_plays_table { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtps_in_session_last_played_amount { get; set; }

    public int? gtps_in_session_last_play { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gtps_updated_played_current { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gtps_updated { get; set; }

    public byte[] gtps_timestamp { get; set; } = null!;

    public long? gtps_import_operation_id { get; set; }

    [StringLength(3)]
    public string gtps_iso_code { get; set; } = null!;
}
