using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class mapp_image
{
    [Key]
    public long im_image_id { get; set; }

    [StringLength(50)]
    public string? im_content_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime im_created_date { get; set; }

    public string? im_file_name { get; set; }

    [StringLength(50)]
    public string? im_name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime im_updated_date { get; set; }

    public byte[]? im_data { get; set; }

    [InverseProperty("ss_background_image")]
    public virtual ICollection<mapp_section_schema> mapp_section_schemass_background_images { get; set; } = new List<mapp_section_schema>();

    [InverseProperty("ss_icon_image")]
    public virtual ICollection<mapp_section_schema> mapp_section_schemass_icon_images { get; set; } = new List<mapp_section_schema>();
}
