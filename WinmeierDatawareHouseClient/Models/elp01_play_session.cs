using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class elp01_play_session
{
    [Key]
    public long eps_id { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_ticket_number { get; set; }

    public long? eps_account_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? eps_slot_serial_number { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string eps_slot_house_number { get; set; } = null!;

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_venue_code { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_area_code { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_bank_code { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_vendor_code { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_game_code { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime eps_start_time { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime eps_end_time { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_bet_amount { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_paid_amount { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_games_played { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_initial_amount { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_aditional_amount { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_final_amount { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? eps_bet_comb_code { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_kindof_ticket { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal eps_sequence_number { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? eps_cupon_number { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime eps_date_updated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? eps_date_inserted { get; set; }
}
