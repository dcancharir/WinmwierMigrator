using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Index("ascr_resource_id", Name = "IX_wkt_ad_step_details_ascr_resource_id")]
public partial class wkt_ad_step_detail
{
    [Key]
    public long ascr_step_id { get; set; }

    public int ascr_zorder { get; set; }

    public int ascr_rect_x { get; set; }

    public int ascr_rect_y { get; set; }

    public int ascr_rect_width { get; set; }

    public int ascr_rect_height { get; set; }

    public int? ascr_media_type { get; set; }

    public long? ascr_resource_id { get; set; }

    public string? ascr_text { get; set; }

    public int? ascr_text_color { get; set; }

    public int? ascr_text_font { get; set; }

    public int? ascr_text_alignment { get; set; }
}
