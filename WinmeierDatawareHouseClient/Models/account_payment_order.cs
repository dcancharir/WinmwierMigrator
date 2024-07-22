using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Index("apo_account_id", "apo_datetime", Name = "IX_apo_account_datetime")]
[Index("apo_datetime", Name = "IX_apo_datetime")]
public partial class account_payment_order
{
    [Key]
    public long apo_operation_id { get; set; }

    public long apo_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime apo_datetime { get; set; }

    [StringLength(50)]
    public string apo_player_name1 { get; set; } = null!;

    [StringLength(50)]
    public string? apo_player_name2 { get; set; }

    [StringLength(50)]
    public string? apo_player_name3 { get; set; }

    [StringLength(20)]
    public string apo_player_doc_type1 { get; set; } = null!;

    [StringLength(20)]
    public string apo_player_doc_id1 { get; set; } = null!;

    [StringLength(20)]
    public string apo_player_doc_type2 { get; set; } = null!;

    [StringLength(20)]
    public string apo_player_doc_id2 { get; set; } = null!;

    [StringLength(50)]
    public string? apo_effective_days { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime apo_application_date { get; set; }

    [StringLength(50)]
    public string? apo_payment_type { get; set; }

    public long apo_bank_id { get; set; }

    [StringLength(50)]
    public string? apo_bank_name { get; set; }

    [StringLength(50)]
    public string? apo_bank_customer_number { get; set; }

    [StringLength(50)]
    public string? apo_bank_account_number { get; set; }

    [Column(TypeName = "money")]
    public decimal apo_account_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal apo_return_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal apo_prize { get; set; }

    [Column(TypeName = "money")]
    public decimal? apo_tax1 { get; set; }

    [Column(TypeName = "money")]
    public decimal? apo_tax2 { get; set; }

    [Column(TypeName = "money")]
    public decimal? apo_tax3 { get; set; }

    [Column(TypeName = "money")]
    public decimal apo_total_payment { get; set; }

    [Column(TypeName = "money")]
    public decimal apo_cash_payment { get; set; }

    [Column(TypeName = "money")]
    public decimal apo_check_payment { get; set; }

    [StringLength(50)]
    public string? apo_authorized_by_title1 { get; set; }

    [StringLength(200)]
    public string? apo_authorized_by_name1 { get; set; }

    [StringLength(50)]
    public string? apo_authorized_by_title2 { get; set; }

    [StringLength(200)]
    public string? apo_authorized_by_name2 { get; set; }

    public long? apo_document_id { get; set; }

    [StringLength(50)]
    public string? apo_player_name4 { get; set; }
}
