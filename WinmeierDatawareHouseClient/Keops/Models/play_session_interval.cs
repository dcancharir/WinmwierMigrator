using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("psi_play_session_id", "psi_account_id", "psi_terminal_id", "psi_day", "psi_hhmm")]
public partial class play_session_interval
{
    [Key]
    public long psi_play_session_id { get; set; }

    [Key]
    public long psi_account_id { get; set; }

    [Key]
    public int psi_terminal_id { get; set; }

    [Key]
    public DateOnly psi_day { get; set; }

    [Key]
    public short psi_hhmm { get; set; }

    public byte psi_week_day { get; set; }

    public byte psi_account_level { get; set; }

    [Column(TypeName = "money")]
    public decimal psi_multiplier_01 { get; set; }

    public int psi_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal psi_played_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal psi_won_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal psi_nr_played { get; set; }

    [Column(TypeName = "money")]
    public decimal psi_nr_won { get; set; }

    [Column(TypeName = "money")]
    public decimal? psi_calculated_points { get; set; }

    public bool? psi_recalculate_points { get; set; }
}
