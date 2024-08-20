using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class flag
{
    public long fl_flag_id { get; set; }

    public int fl_type { get; set; }

    public int fl_status { get; set; }

    public int fl_expiration_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fl_expiration_date { get; set; }

    public int? fl_expiration_interval { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fl_created { get; set; }

    [StringLength(100)]
    public string fl_name { get; set; } = null!;

    [StringLength(500)]
    public string? fl_description { get; set; }

    public int fl_color { get; set; }

    public long? fl_related_id { get; set; }

    public int? fl_related_type { get; set; }

    public int? fl_site_id { get; set; }

    public long? fl_ms_flag_id { get; set; }

    public int fl_ms_pending { get; set; }

    public long? fl_timestamp { get; set; }
}
