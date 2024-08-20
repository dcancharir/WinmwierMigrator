using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class food_beverage_catalog
{
    public long fbc_id { get; set; }

    public long fbc_external_id { get; set; }

    public int fbc_type { get; set; }

    public long? fbc_parent_id { get; set; }

    [StringLength(60)]
    public string? fbc_name { get; set; }

    [StringLength(120)]
    public string? fbc_long_name { get; set; }

    [MaxLength(1)]
    public byte[]? fbc_image { get; set; }

    [Column(TypeName = "money")]
    public decimal? fbc_price { get; set; }

    public int? fbc_number { get; set; }

    public int? fbc_sort { get; set; }

    [StringLength(500)]
    public string? fbc_comment { get; set; }

    public int fbc_sync_status { get; set; }

    public long fbc_sync_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fbc_created_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fbc_last_update_date { get; set; }

    [Column(TypeName = "money")]
    public decimal? fbc_price_points { get; set; }
}
