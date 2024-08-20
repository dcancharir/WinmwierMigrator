using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class bank_transaction
{
    [Key]
    public long bt_operation_id { get; set; }

    public int bt_type { get; set; }

    [StringLength(50)]
    public string bt_document_number { get; set; } = null!;

    [StringLength(50)]
    public string? bt_bank_name { get; set; }

    public int? bt_bank_country { get; set; }

    [StringLength(200)]
    public string? bt_holder_name { get; set; }

    [StringLength(5)]
    public string? bt_card_expiration_date { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string? bt_card_track_data { get; set; }

    [Column(TypeName = "money")]
    public decimal bt_amount { get; set; }

    [StringLength(3)]
    public string bt_iso_code { get; set; } = null!;

    public int bt_user_id { get; set; }

    public int bt_cashier_id { get; set; }

    [StringLength(50)]
    public string bt_user_name { get; set; } = null!;

    [StringLength(50)]
    public string bt_cashier_name { get; set; } = null!;

    public int bt_transaction_type { get; set; }

    public bool bt_edited { get; set; }

    [StringLength(50)]
    public string? bt_check_routing_number { get; set; }

    [StringLength(50)]
    public string? bt_check_account_number { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? bt_check_date { get; set; }

    [StringLength(256)]
    public string? bt_comments { get; set; }

    [StringLength(50)]
    public string? bt_account_track_data { get; set; }

    [StringLength(200)]
    public string? bt_account_holder_name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? bt_banktransfer_value_date { get; set; }

    [StringLength(50)]
    public string? bt_banktransfer_payer { get; set; }

    [StringLength(20)]
    public string? bt_banktransfer_reference { get; set; }

    [StringLength(100)]
    public string? bt_banktransfer_concept { get; set; }
}
