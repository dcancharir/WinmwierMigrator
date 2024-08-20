using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("draw_period_of_study")]
public partial class draw_period_of_study
{
    public long drpos_id { get; set; }

    public long drpos_draw_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime drpos_earning_date_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime drpos_earning_date_finish { get; set; }

    public int drpos_earning_time_start { get; set; }

    public int drpos_earning_time_finish { get; set; }

    public int drpos_earning_days { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime drpos_activation_date_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime drpos_activation_date_finish { get; set; }

    public int drpos_activation_time_start { get; set; }

    public int drpos_activation_time_finish { get; set; }

    public int drpos_activation_days { get; set; }
}
