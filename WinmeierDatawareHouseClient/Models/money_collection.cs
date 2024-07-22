using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Index("mc_cashier_session_id", Name = "IX_mc_cashier_session_id")]
[Index("mc_cashier_session_id", "mc_terminal_id", Name = "IX_mc_cashier_session_terminal_id")]
[Index("mc_collection_datetime", Name = "IX_mc_collection_datetime")]
[Index("mc_datetime", Name = "IX_mc_datetime")]
[Index("mc_terminal_id", Name = "IX_mc_terminal_id")]
[Index("mc_terminal_id", "mc_stacker_id", "mc_wcp_transaction_id", Name = "IX_mc_terminal_stacker_transaction")]
public partial class money_collection
{
    [Key]
    public long mc_collection_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mc_datetime { get; set; }

    public int? mc_terminal_id { get; set; }

    public int? mc_user_id { get; set; }

    public bool mc_undo_collect { get; set; }

    public bool mc_money_lost { get; set; }

    public long? mc_cashier_session_id { get; set; }

    [StringLength(200)]
    public string? mc_notes { get; set; }

    public long? mc_stacker_id { get; set; }

    public int? mc_inserted_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mc_collection_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mc_extraction_datetime { get; set; }

    public int? mc_status { get; set; }

    public int? mc_cashier_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_expected_bill_amount { get; set; }

    public int? mc_expected_bill_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_expected_ticket_amount { get; set; }

    public int? mc_expected_ticket_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_expected_re_ticket_amount { get; set; }

    public int? mc_expected_re_ticket_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_expected_promo_re_ticket_amount { get; set; }

    public int? mc_expected_promo_re_ticket_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_expected_promo_nr_ticket_amount { get; set; }

    public int? mc_expected_promo_nr_ticket_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_collected_bill_amount { get; set; }

    public int? mc_collected_bill_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_collected_ticket_amount { get; set; }

    public int? mc_collected_ticket_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_collected_re_ticket_amount { get; set; }

    public int? mc_collected_re_ticket_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_collected_promo_re_ticket_amount { get; set; }

    public int? mc_collected_promo_re_ticket_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_collected_promo_nr_ticket_amount { get; set; }

    public int? mc_collected_promo_nr_ticket_count { get; set; }

    [Column(TypeName = "xml")]
    public string? mc_note_counter_events { get; set; }

    public long? mc_wcp_transaction_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_expected_coin_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal mc_collected_coin_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mc_last_updated { get; set; }

    [Column(TypeName = "xml")]
    public string? mc_refilled_hopper { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_out_bills { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_out_coins { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_out_cents { get; set; }

    [Column(TypeName = "xml")]
    public string? mc_initial_meters { get; set; }

    [Column(TypeName = "xml")]
    public string? mc_final_meters { get; set; }
}
