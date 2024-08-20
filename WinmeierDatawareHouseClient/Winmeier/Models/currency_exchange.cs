using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("ce_type", "ce_currency_iso_code")]
[Table("currency_exchange")]
public partial class currency_exchange
{
    [Key]
    public int ce_type { get; set; }

    [Key]
    [StringLength(3)]
    public string ce_currency_iso_code { get; set; } = null!;

    [StringLength(50)]
    public string? ce_description { get; set; }

    [Column(TypeName = "decimal(16, 8)")]
    public decimal ce_change { get; set; }

    public int? ce_num_decimals { get; set; }

    [Column(TypeName = "money")]
    public decimal? ce_variable_commission { get; set; }

    [Column(TypeName = "money")]
    public decimal? ce_fixed_commission { get; set; }

    [Column(TypeName = "money")]
    public decimal? ce_variable_nr2 { get; set; }

    [Column(TypeName = "money")]
    public decimal? ce_fixed_nr2 { get; set; }

    public bool ce_status { get; set; }

    public int? ce_formatted_decimals { get; set; }

    [Column(TypeName = "xml")]
    public string? ce_language_resources { get; set; }

    public long? ce_currency_order { get; set; }

    [Column(TypeName = "xml")]
    public string? ce_configuration { get; set; }
}
