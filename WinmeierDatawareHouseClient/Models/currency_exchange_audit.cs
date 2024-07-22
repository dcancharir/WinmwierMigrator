using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Table("currency_exchange_audit")]
[Index("cea_currency_iso_code", "cea_type", "cea_datetime", Name = "IX_cea_iso_code_type_datetime")]
public partial class currency_exchange_audit
{
    [Key]
    public long cea_audit_id { get; set; }

    public int cea_type { get; set; }

    [StringLength(3)]
    public string cea_currency_iso_code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime cea_datetime { get; set; }

    [Column(TypeName = "decimal(16, 8)")]
    public decimal cea_old_change { get; set; }

    [Column(TypeName = "decimal(16, 8)")]
    public decimal cea_new_change { get; set; }

    public int cea_old_num_decimals { get; set; }

    public int cea_new_num_decimals { get; set; }
}
