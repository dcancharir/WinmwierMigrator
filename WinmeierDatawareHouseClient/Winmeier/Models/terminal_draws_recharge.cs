using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

public partial class terminal_draws_recharge
{
    [Key]
    public long tdr_id { get; set; }

    public long tdr_account_id { get; set; }

    public int tdr_status { get; set; }

    [Column(TypeName = "money")]
    public decimal? tdr_total_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? tdr_re_bet { get; set; }

    [Column(TypeName = "money")]
    public decimal? tdr_nr_bet { get; set; }

    [Column(TypeName = "money")]
    public decimal? tdr_points_bet { get; set; }

    public long tdr_operation_id { get; set; }

    public long tdr_game_id { get; set; }

    public int? trd_draw_type { get; set; }

    [Column(TypeName = "money")]
    public decimal? trd_draw_price { get; set; }

    public int? trd_draw_num_plays { get; set; }

    public int? trd_draw_num_winner_plays { get; set; }

    [Column(TypeName = "money")]
    public decimal? trd_total_bet { get; set; }

    [Column(TypeName = "money")]
    public decimal? trd_total_win { get; set; }

    [Column(TypeName = "money")]
    public decimal? trd_buffet_amount { get; set; }
}
