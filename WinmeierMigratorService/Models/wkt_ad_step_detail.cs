using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

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

    [ForeignKey("ascr_resource_id")]
    [InverseProperty("wkt_ad_step_details")]
    public virtual wkt_resource? ascr_resource { get; set; }

    [ForeignKey("ascr_step_id")]
    [InverseProperty("wkt_ad_step_detail")]
    public virtual wkt_ad_step ascr_step { get; set; } = null!;
}
