using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("GamingDay", "AccountId")]
[Table("bucket01_daily")]
[Index("AccountId", "GamingDay", Name = "IX_bucket01_AccountId_GamingDay")]
public partial class bucket01_daily
{
    [Key]
    public int GamingDay { get; set; }

    [Key]
    public long AccountId { get; set; }

    [Column(TypeName = "money")]
    public decimal? InitialBalance { get; set; }

    [Column(TypeName = "money")]
    public decimal? Earned { get; set; }

    [Column(TypeName = "money")]
    public decimal? Awarded { get; set; }

    [Column(TypeName = "money")]
    public decimal? Redeemed { get; set; }

    [Column(TypeName = "money")]
    public decimal? ManualAdjusted { get; set; }

    [Column(TypeName = "money")]
    public decimal? Expired { get; set; }

    [Column(TypeName = "money")]
    public decimal? Increment { get; set; }

    [Column(TypeName = "money")]
    public decimal? FinalBalance { get; set; }

    public int? LastActivity { get; set; }
}
