using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class threshold_operation
{
    public long to_threshold_id { get; set; }

    public int to_transaction_type { get; set; }

    public int to_transaction_subtype { get; set; }

    [Column(TypeName = "money")]
    public decimal to_total_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal to_cash_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime to_transaction_date { get; set; }

    public long? to_operation_id { get; set; }

    public int? to_operation_code { get; set; }

    public long? to_undo_operation_id { get; set; }

    public int? to_holder_id_type { get; set; }

    [StringLength(40)]
    public string to_holder_id { get; set; } = null!;

    public int to_user_id { get; set; }

    [StringLength(100)]
    public string to_user_name { get; set; } = null!;

    public long to_account_id { get; set; }

    [StringLength(400)]
    public string? to_holder_name { get; set; }

    [StringLength(100)]
    public string? to_holder_name1 { get; set; }

    [StringLength(100)]
    public string? to_holder_name2 { get; set; }

    [StringLength(100)]
    public string? to_holder_name3 { get; set; }

    [StringLength(100)]
    public string? to_holder_name4 { get; set; }

    [StringLength(100)]
    public string? to_holder_address_01 { get; set; }

    [StringLength(100)]
    public string? to_holder_address_02 { get; set; }

    [StringLength(100)]
    public string? to_holder_address_03 { get; set; }

    [StringLength(20)]
    public string? to_holder_ext_num { get; set; }

    [StringLength(100)]
    public string? to_holder_city { get; set; }

    public int? to_holder_fed_entity { get; set; }

    [StringLength(20)]
    public string? to_holder_zip { get; set; }

    public int? to_holder_address_country { get; set; }

    public int? to_holder_nationality { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? to_holder_birth_date { get; set; }

    public int? to_holder_occupation_id { get; set; }

    [MaxLength(1)]
    public byte[]? to_scanned_Identity_card { get; set; }
}
