using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("cue_entrance_datetime", "cue_visit_id")]
[Index("cue_visit_id", Name = "IX_cue_visit_id")]
[Index("cue_visit_id", Name = "IX_dta_index_customer_entrances_cue_visit_id")]
public partial class customer_entrance
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime cue_entrance_datetime { get; set; }

    [Key]
    public long cue_visit_id { get; set; }

    public long? cue_cashier_session_id { get; set; }

    public int? cue_cashier_user_id { get; set; }

    public int? cue_entrance_block_reason { get; set; }

    public int? cue_entrance_block_reason2 { get; set; }

    [StringLength(256)]
    public string? cue_entrance_block_description { get; set; }

    [StringLength(256)]
    public string? cue_remarks { get; set; }

    public long? cue_ticket_entry_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? cue_ticket_entry_price_real { get; set; }

    public int? cue_document_type { get; set; }

    [StringLength(50)]
    public string? cue_document_number { get; set; }

    public long? cue_voucher_id { get; set; }

    public long? cue_cashier_terminal_id { get; set; }

    [StringLength(250)]
    public string? cue_coupon { get; set; }

    public long? cue_voucher_sequence { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cue_entrance_expiration { get; set; }

    [Column(TypeName = "money")]
    public decimal? cue_ticket_entry_price_paid { get; set; }

    [Column(TypeName = "money")]
    public decimal? cue_ticket_entry_price_difference { get; set; }

    public int cut_included_in_black_list { get; set; }

    public bool cut_op_acknowledged_black_list { get; set; }

    public string? cue_price_description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cue_exit_datetime { get; set; }

    public int? cue_exit_reason { get; set; }
}
