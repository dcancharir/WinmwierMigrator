using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("pvh_account_id", "pvh_date")]
[Table("h_pvh")]
public partial class h_pvh
{
    [Key]
    public long pvh_account_id { get; set; }

    [Key]
    public int pvh_date { get; set; }

    public byte pvh_weekday { get; set; }

    public byte? pvh_visit { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pvh_check_in { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pvh_check_out { get; set; }

    public int? pvh_room_time { get; set; }

    public int? pvh_game_time { get; set; }

    public int? pvh_total_played_count { get; set; }

    public int? pvh_played_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_total_played { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_total_bet_avg { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_jackpots_won { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_total_won { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_re_played { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_nr_played { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_theorical_won { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_money_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_money_in_tax { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_money_out { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_re_won { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_nr_won { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_devolution { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_prize { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_tax1 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_tax2 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pvh_tax3 { get; set; }

    public int? pvh_money_in_count { get; set; }

    public int? pvh_money_out_count { get; set; }

    public byte? pvh_age { get; set; }

    public short? pvh_registered_num_days { get; set; }

    public int? pvh_level { get; set; }

    public long? pvh_points_balance { get; set; }

    public long? pvh_points_manual { get; set; }

    public long? pvh_points_won { get; set; }

    public long? pvh_points_redeemed { get; set; }

    public long? pvh_points_expired { get; set; }
}
