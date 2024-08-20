using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("ev_account_id", "ev_voucher_id")]
public partial class elp01_voucher
{
    [Key]
    public long ev_account_id { get; set; }

    [Key]
    [StringLength(50)]
    public string ev_voucher_id { get; set; } = null!;

    public int ev_credit_type { get; set; }

    [Column(TypeName = "money")]
    public decimal ev_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ev_datetime { get; set; }

    public long ev_operation_id { get; set; }
}
