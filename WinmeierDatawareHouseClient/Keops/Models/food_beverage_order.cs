using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class food_beverage_order
{
    public long fbo_id { get; set; }

    public long fbo_account_id { get; set; }

    public int? fbo_terminal_id { get; set; }

    public long? fbo_play_session_id { get; set; }

    [StringLength(200)]
    public string? fbo_track_data { get; set; }

    public long fbo_catalog_id { get; set; }

    [StringLength(500)]
    public string? fbo_terminal_location { get; set; }

    public int fbo_status { get; set; }

    public int fbo_provider_status { get; set; }

    public int fbo_catalog_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fbo_request_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fbo_last_update_date { get; set; }

    [Column(TypeName = "money")]
    public decimal? fbo_points_amount { get; set; }
}
