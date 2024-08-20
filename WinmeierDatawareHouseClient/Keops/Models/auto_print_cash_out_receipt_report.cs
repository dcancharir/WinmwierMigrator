using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("auto_print_cash_out_receipt_report")]
public partial class auto_print_cash_out_receipt_report
{
    [Key]
    public long apcurr_voucher_id { get; set; }

    public long apcurr_play_session_id { get; set; }

    public int apcurr_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? apcurr_datetime { get; set; }

    [StringLength(50)]
    public string? apcurr_provider { get; set; }

    [StringLength(50)]
    public string? apcurr_egm { get; set; }

    public long? apcurr_transaction_no { get; set; }

    public long? apcurr_receipt_no { get; set; }

    [Column(TypeName = "money")]
    public decimal? apcurr_amount { get; set; }

    public long? apcurr_prov_id { get; set; }

    public long? apcurr_account_id { get; set; }

    [StringLength(50)]
    public string? apcurr_account_holder { get; set; }

    public long? apcurr_terminal_id { get; set; }
}
