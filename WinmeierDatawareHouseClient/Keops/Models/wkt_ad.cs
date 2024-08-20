using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class wkt_ad
{
    public long ad_id { get; set; }

    [StringLength(100)]
    public string ad_name { get; set; } = null!;

    [StringLength(1000)]
    public string ad_description { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ad_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ad_to { get; set; }

    public bool ad_enabled { get; set; }

    public int ad_weekday { get; set; }

    public int ad_time_from1 { get; set; }

    public int ad_time_to1 { get; set; }

    public int? ad_time_from2 { get; set; }

    public int? ad_time_to2 { get; set; }

    public short? ad_target { get; set; }

    [StringLength(1000)]
    public string? ad_abstract { get; set; }

    public short? ad_order { get; set; }

    public long? ad_list_resource_id { get; set; }

    public long? ad_detail_resource_id { get; set; }

    public long? ad_target_schemaId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ad_last_update_date { get; set; }

    public bool ad_promobox_enabled { get; set; }

    public bool ad_winup_enabled { get; set; }

    [StringLength(1000)]
    public string? ad_list_description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ad_winup_valid_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ad_winup_valid_to { get; set; }

    [StringLength(300)]
    public string? ad_winup_title { get; set; }
}
