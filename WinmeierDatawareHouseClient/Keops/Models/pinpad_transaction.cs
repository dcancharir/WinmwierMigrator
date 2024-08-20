using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class pinpad_transaction
{
    public long pt_id { get; set; }

    [StringLength(100)]
    public string pt_transaction { get; set; } = null!;

    public int pt_user_id { get; set; }

    public long pt_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pt_created { get; set; }

    [StringLength(40)]
    public string pt_bank_name { get; set; } = null!;

    [StringLength(32)]
    public string pt_card_number { get; set; } = null!;

    public int pt_card_type { get; set; }

    [StringLength(6)]
    public string pt_card_iso_code { get; set; } = null!;

    [StringLength(100)]
    public string pt_card_holder { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal pt_transaction_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal pt_commission_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal pt_total_amount { get; set; }

    public int pt_status { get; set; }

    [StringLength(400)]
    public string? pt_error_message { get; set; }

    [StringLength(100)]
    public string? pt_control_number { get; set; }

    [StringLength(100)]
    public string? pt_reference { get; set; }

    public long? pt_operation_id { get; set; }

    public long? pt_merchant_id { get; set; }

    [StringLength(20)]
    public string? pt_auth_code { get; set; }

    public bool pt_collected { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pt_last_modified { get; set; }

    public long PT_RETRY { get; set; }

    [StringLength(100)]
    public string? pt_cashier_name { get; set; }

    public int? pt_pinpad_id { get; set; }
}
