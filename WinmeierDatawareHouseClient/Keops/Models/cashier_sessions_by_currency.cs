using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("csc_session_id", "csc_iso_code", "csc_type")]
[Table("cashier_sessions_by_currency")]
public partial class cashier_sessions_by_currency
{
    [Key]
    public long csc_session_id { get; set; }

    [Key]
    [StringLength(3)]
    public string csc_iso_code { get; set; } = null!;

    [Key]
    public int csc_type { get; set; }

    [Column(TypeName = "money")]
    public decimal csc_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal csc_collected { get; set; }
}
