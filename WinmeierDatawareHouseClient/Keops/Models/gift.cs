using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class gift
{
    public long gi_gift_id { get; set; }

    [StringLength(100)]
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

    [StringLength(400)]
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

    [StringLength(100)]
    public string? gi_text_on_promobox { get; set; }

    [Column(TypeName = "xml")]
    public string? gi_pyramidal_dist { get; set; }

    public bool? GI_ACTIVE_PYRAMIDAL_DIST { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level5 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level6 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level7 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level8 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level9 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level10 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level11 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level12 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level13 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level14 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level15 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level16 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level17 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level18 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level19 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level20 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level21 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level22 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level23 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level24 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level25 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level26 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level27 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level28 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level29 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level30 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_points_level31 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gi_amount_prize_tax_form { get; set; }

    public long? gi_small_resource_id_55 { get; set; }
}
