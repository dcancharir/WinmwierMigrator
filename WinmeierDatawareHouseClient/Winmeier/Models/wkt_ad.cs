using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

public partial class wkt_ad
{
    [Key]
    public long ad_id { get; set; }

    [StringLength(50)]
    public string ad_name { get; set; } = null!;

    [StringLength(500)]
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
}
