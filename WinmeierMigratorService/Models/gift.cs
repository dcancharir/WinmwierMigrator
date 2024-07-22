using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class gift
{
    [Key]
    public long gi_gift_id { get; set; }

    [StringLength(50)]
    public string gi_name { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? gi_points { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_conversion_to_nrc { get; set; }

    public bool gi_available { get; set; }

    public int gi_type { get; set; }

    public int gi_current_stock { get; set; }

    public int gi_request_counter { get; set; }

    public int gi_delivery_counter { get; set; }

    public long? gi_small_resource_id { get; set; }

    public long? gi_large_resource_id { get; set; }

    [StringLength(200)]
    public string gi_description { get; set; } = null!;

    public int? gi_account_daily_limit { get; set; }

    public int? gi_account_monthly_limit { get; set; }

    public int? gi_global_daily_limit { get; set; }

    public int? gi_global_monthly_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level1 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level2 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level3 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level4 { get; set; }

    public long? gi_points_to_credits_id { get; set; }

    public bool? gi_vip { get; set; }

    public bool gi_award_on_promobox { get; set; }

    [StringLength(50)]
    public string? gi_text_on_promobox { get; set; }
}
