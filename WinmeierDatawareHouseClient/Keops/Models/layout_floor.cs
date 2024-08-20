using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_floor
{
    public int lf_floor_id { get; set; }

    [Unicode(false)]
    public string? lf_geometry { get; set; }

    [Unicode(false)]
    public string? lf_image_map { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? lf_color { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? lf_name { get; set; }

    public int? lf_height { get; set; }

    public int? lf_width { get; set; }

    public int? lf_metric { get; set; }
}
