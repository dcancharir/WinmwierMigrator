using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class cashier_session
{
    public long cs_session_id { get; set; }

    [StringLength(100)]
    public string cs_name { get; set; } = null!;

    public int cs_cashier_id { get; set; }

    public int cs_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cs_opening_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cs_closing_date { get; set; }

    public int cs_status { get; set; }

    [Column(TypeName = "money")]
    public decimal cs_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal cs_other_balance_1 { get; set; }

    [Column(TypeName = "money")]
    public decimal cs_other_balance_2 { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? cs_tax_a_pct { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? cs_tax_b_pct { get; set; }

    [Column(TypeName = "money")]
    public decimal? cs_collected_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? cs_sales_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal? cs_total_sold { get; set; }

    [Column(TypeName = "money")]
    public decimal? cs_mb_sales_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal? cs_mb_total_sold { get; set; }

    public bool cs_session_by_terminal { get; set; }

    public bool cs_history { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cs_gaming_day { get; set; }

    public bool cs_short_over_history { get; set; }

    public long? cs_has_pinpad_operations { get; set; }

    public int? cs_venue_id { get; set; }

    public bool? cs_is_session_collector { get; set; }
}
