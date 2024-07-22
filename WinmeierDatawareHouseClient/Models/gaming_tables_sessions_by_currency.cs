using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("gtsc_gaming_table_session_id", "gtsc_iso_code", "gtsc_type")]
[Table("gaming_tables_sessions_by_currency")]
public partial class gaming_tables_sessions_by_currency
{
    [Key]
    public long gtsc_gaming_table_session_id { get; set; }

    [Key]
    [StringLength(3)]
    public string gtsc_iso_code { get; set; } = null!;

    [Key]
    public int gtsc_type { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_fills_chips_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_credits_chips_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_own_sales_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_external_sales_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_collected_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_collected_amount_converted { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_own_purchase_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_external_purchase_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_tips { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_total_sales_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_total_purchase_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_collected_dropbox_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_collected_dropbox_amount_converted { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_initial_chips_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtsc_final_chips_amount { get; set; }
}
