using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("gdw_gaming_day", "gdw_tid", "gdw_mcid")]
[Table("gdw")]
public partial class gdw
{
    [Key]
    public int gdw_gaming_day { get; set; }

    [Key]
    public long gdw_tid { get; set; }

    [Key]
    public long gdw_mcid { get; set; }

    public bool? gdw_drop { get; set; }

    [Column(TypeName = "money")]
    public decimal? gdw_exp_bill { get; set; }

    [Column(TypeName = "money")]
    public decimal? gdw_exp_ticket { get; set; }

    [Column(TypeName = "money")]
    public decimal? gdw_daily_bill { get; set; }

    [Column(TypeName = "money")]
    public decimal? gdw_daily_ticket { get; set; }
}
