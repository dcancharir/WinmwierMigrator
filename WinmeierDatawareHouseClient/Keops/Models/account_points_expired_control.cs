using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("apec_day_month", "apec_year")]
[Table("account_points_expired_control")]
public partial class account_points_expired_control
{
    [Key]
    [StringLength(5)]
    public string apec_day_month { get; set; } = null!;

    [Key]
    public int apec_year { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? apec_execution { get; set; }
}
