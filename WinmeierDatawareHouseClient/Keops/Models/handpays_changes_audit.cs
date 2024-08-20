using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("hca_hpid", "hca_id")]
[Table("handpays_changes_audit")]
public partial class handpays_changes_audit
{
    [Key]
    public long hca_id { get; set; }

    [Key]
    public long hca_hpid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime hca_insert_date { get; set; }

    public int? hca_status { get; set; }

    public int? hca_old_status { get; set; }

    public int? hca_terminal_id { get; set; }

    [StringLength(50)]
    public string? hca_game_base_name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime hca_created_datetime { get; set; }

    [Column(TypeName = "money")]
    public decimal hca_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal hca_old_amount { get; set; }

    [StringLength(50)]
    public string? hca_te_name { get; set; }

    [StringLength(50)]
    public string? hca_te_provider_id { get; set; }

    public long? hca_movement_id { get; set; }

    public int hca_type { get; set; }

    public long? hca_play_session_id { get; set; }

    public int? hca_site_jackpot_index { get; set; }

    [StringLength(50)]
    public string? hca_site_jackpot_name { get; set; }

    public int? hca_site_jackpot_awarded_on_terminal_id { get; set; }

    public long? hca_site_jackpot_awarded_to_account_id { get; set; }

    public bool hca_site_jackpot_notified { get; set; }

    public long? hca_ticket_id { get; set; }

    public long? hca_transaction_id { get; set; }

    public long? hca_candidate_play_session_id { get; set; }

    public long? hca_candidate_prev_play_session_id { get; set; }

    [Column(TypeName = "xml")]
    public string? hca_long_poll_1b_data { get; set; }

    public long? hca_progressive_id { get; set; }

    public int? hca_level { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? hca_date_status_changed { get; set; }

    [Column(TypeName = "money")]
    public decimal? hca_tax_base_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? hca_tax_amount { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? hca_tax_pct { get; set; }

    [Column(TypeName = "money")]
    public decimal? hca_old_tax_base_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? hca_old_tax_amount { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? hca_old_tax_pct { get; set; }

    public int hca_payment_mode { get; set; }

    public int? hca_status_calculated { get; set; }

    public long? hca_operation_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? hca_amt0 { get; set; }

    [StringLength(3)]
    public string? hca_cur0 { get; set; }

    [Column(TypeName = "money")]
    public decimal? hca_amt1 { get; set; }

    [StringLength(3)]
    public string? hca_cur1 { get; set; }

    [Column(TypeName = "money")]
    public decimal? hca_old_amt0 { get; set; }

    [StringLength(3)]
    public string? hca_old_cur0 { get; set; }

    [Column(TypeName = "money")]
    public decimal? hca_old_amt1 { get; set; }

    [StringLength(3)]
    public string? hca_old_cur1 { get; set; }

    public int? hca_tax_apply_type { get; set; }

    public int? hca_old_tax_apply_type { get; set; }

    [StringLength(256)]
    public string? hca_void_comments { get; set; }

    public long? hca_account_id { get; set; }

    public long? hca_old_account_id { get; set; }

    public long? hca_operation_id_authorization { get; set; }

    [Column(TypeName = "money")]
    public decimal? hca_original_amount { get; set; }

    [StringLength(50)]
    public string? hca_void_user { get; set; }

    [StringLength(50)]
    public string? hca_void_terminal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? hca_void_date { get; set; }
}
