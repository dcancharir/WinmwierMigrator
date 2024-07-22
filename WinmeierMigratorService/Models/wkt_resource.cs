using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class wkt_resource
{
    [Key]
    public long res_resource_id { get; set; }

    [StringLength(50)]
    public string res_extension { get; set; } = null!;

    public int res_length { get; set; }

    public byte[]? res_data { get; set; }

    [MaxLength(50)]
    public byte[]? res_hash { get; set; }

    [InverseProperty("ascr_resource")]
    public virtual ICollection<wkt_ad_step_detail> wkt_ad_step_details { get; set; } = new List<wkt_ad_step_detail>();
}
