using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("amd_day", "amd_account_id", "amd_track_data")]
[Table("aml_daily")]
[Index("amd_account_id", "amd_day", Name = "IX_amd_account_day")]
public partial class aml_daily
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime amd_day { get; set; }

    [Key]
    public long amd_account_id { get; set; }

    [Key]
    [StringLength(50)]
    public string amd_track_data { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal amd_split_a { get; set; }

    [Column(TypeName = "money")]
    public decimal amd_prize { get; set; }
}
