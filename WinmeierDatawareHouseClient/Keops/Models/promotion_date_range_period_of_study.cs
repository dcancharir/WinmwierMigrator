using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("promotion_date_range_period_of_study")]
public partial class promotion_date_range_period_of_study
{
    public long pdrpos_id { get; set; }

    public long pdrpos_promotion_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pdrpos_earning_date_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pdrpos_earning_date_to { get; set; }

    public int pdrpos_earning_time_from { get; set; }

    public int pdrpos_earning_time_to { get; set; }

    public int pdrpos_earning_week_day { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pdrpos_activation_date_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pdrpos_activation_date_to { get; set; }

    public int pdrpos_activation_time_from { get; set; }

    public int pdrpos_activation_time_to { get; set; }

    public int pdrpos_activation_week_day { get; set; }
}
