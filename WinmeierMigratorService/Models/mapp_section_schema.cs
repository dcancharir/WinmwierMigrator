using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("mapp_section_schema")]
public partial class mapp_section_schema
{
    [Key]
    public long ss_section_schema_id { get; set; }

    public bool ss_active { get; set; }

    public bool ss_deleted { get; set; }

    public long? ss_icon_image_id { get; set; }

    public long? ss_background_image_id { get; set; }

    [StringLength(50)]
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

    [InverseProperty("ss_parent")]
    public virtual ICollection<mapp_section_schema> Inversess_parent { get; set; } = new List<mapp_section_schema>();

    [ForeignKey("ss_background_image_id")]
    [InverseProperty("mapp_section_schemass_background_images")]
    public virtual mapp_image? ss_background_image { get; set; }

    [ForeignKey("ss_icon_image_id")]
    [InverseProperty("mapp_section_schemass_icon_images")]
    public virtual mapp_image? ss_icon_image { get; set; }

    [ForeignKey("ss_parent_id")]
    [InverseProperty("Inversess_parent")]
    public virtual mapp_section_schema? ss_parent { get; set; }
}
