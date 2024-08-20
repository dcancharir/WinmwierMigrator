using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class hot_seats_launch_parameter
{
    [Key]
    public long hslp_hs_id { get; set; }

    public bool hslp_earn_requirement_enabled { get; set; }

    [Column(TypeName = "money")]
    public decimal? hslp_earn_requirement_minimum_value { get; set; }

    public int? hslp_earn_requirement_minimum_type { get; set; }

    public int? hslp_earn_requirement_schedule_before { get; set; }

    public int? hslp_earn_requirement_schedule_type { get; set; }
}
