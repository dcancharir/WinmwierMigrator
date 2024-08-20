using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("mapp_section_schema")]
public partial class mapp_section_schema
{
    public long ss_section_schema_id { get; set; }

    public bool ss_active { get; set; }

    public bool ss_deleted { get; set; }

    public long? ss_icon_image_id { get; set; }

    public long? ss_background_image_id { get; set; }

    [StringLength(100)]
    public string? ss_name { get; set; }

    public long? ss_parent_id { get; set; }

    public int? ss_tipo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ss_last_update_date { get; set; }

    public short? ss_order { get; set; }

    public bool? ss_isfooter { get; set; }

    public bool? ss_footer_active { get; set; }

    public long? ss_footer_image_id { get; set; }

    public int? ss_footer_order { get; set; }
}
