using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Table("winstats_cashier_day")]
public partial class winstats_cashier_day
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime wcd_date { get; set; }

    [Column(TypeName = "money")]
    public decimal wcd_input { get; set; }

    [Column(TypeName = "money")]
    public decimal wcd_output { get; set; }

    [Column(TypeName = "money")]
    public decimal wcd_taxes { get; set; }

    [Column(TypeName = "money")]
    public decimal wcd_stacker_expected { get; set; }

    [Column(TypeName = "money")]
    public decimal wcd_result { get; set; }

    [Column(TypeName = "money")]
    public decimal wcd_take { get; set; }
}
