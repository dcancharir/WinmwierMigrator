using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("amm_month", "amm_account_id", "amm_track_data")]
[Table("aml_monthly")]
[Index("amm_account_id", "amm_month", Name = "IX_amm_account_month")]
public partial class aml_monthly
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime amm_month { get; set; }

    [Key]
    public long amm_account_id { get; set; }

    [Key]
    [StringLength(50)]
    public string amm_track_data { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal amm_split_a { get; set; }

    [Column(TypeName = "money")]
    public decimal amm_prize { get; set; }
}
