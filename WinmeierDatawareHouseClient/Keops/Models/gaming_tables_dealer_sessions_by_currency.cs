using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("gtdsc_dealer_session_id", "gtdsc_iso_code", "gtdsc_cage_currency_type")]
[Table("gaming_tables_dealer_sessions_by_currency")]
[Index("gtdsc_dealer_session_id", "gtdsc_cage_currency_type", Name = "IX_gtdsc_dealersessionid_cagecurrencytype", IsDescending = new[] { true, false })]
public partial class gaming_tables_dealer_sessions_by_currency
{
    [Key]
    public long gtdsc_dealer_session_id { get; set; }

    [Key]
    [StringLength(3)]
    public string gtdsc_iso_code { get; set; } = null!;

    [Key]
    public int gtdsc_cage_currency_type { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtdsc_fills_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtdsc_credits_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtdsc_drop_amount { get; set; }
}
