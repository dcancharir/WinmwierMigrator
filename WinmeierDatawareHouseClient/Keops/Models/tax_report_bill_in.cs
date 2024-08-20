using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("tax_report_bill_in")]
public partial class tax_report_bill_in
{
    public long trbi_id { get; set; }

    public short trbi_source_type { get; set; }

    public int trbi_cashier_id { get; set; }

    [StringLength(100)]
    public string trbi_cashier_name { get; set; } = null!;

    public int trbi_terminal_id { get; set; }

    [StringLength(100)]
    public string trbi_uid { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime trbi_date { get; set; }

    [Column(TypeName = "money")]
    public decimal trbi_egm_account_denom { get; set; }

    [Column(TypeName = "money")]
    public decimal trbi_bill_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal trbi_tax_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal trbi_tax_applied_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal trbi_amount_to_bet { get; set; }

    public byte[]? trbi_timestamp { get; set; }

    public long? trbi_operation_id { get; set; }
}
