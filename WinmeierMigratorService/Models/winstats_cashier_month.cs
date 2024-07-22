using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("winstats_cashier_month")]
public partial class winstats_cashier_month
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime wcm_date { get; set; }

    [Column(TypeName = "money")]
    public decimal wcm_input { get; set; }

    [Column(TypeName = "money")]
    public decimal wcm_output { get; set; }

    [Column(TypeName = "money")]
    public decimal wcm_taxes { get; set; }

    [Column(TypeName = "money")]
    public decimal wcm_stacker_expected { get; set; }

    [Column(TypeName = "money")]
    public decimal wcm_result { get; set; }

    [Column(TypeName = "money")]
    public decimal wcm_take { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime wcm_lastupdateddate { get; set; }
}
