using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class wkt_ad_step
{
    public long? as_ad_id { get; set; }

    [Key]
    public long as_step_id { get; set; }

    public int as_step_order { get; set; }

    public int? as_duration { get; set; }

    [ForeignKey("as_ad_id")]
    [InverseProperty("wkt_ad_steps")]
    public virtual wkt_ad? as_ad { get; set; }

    [InverseProperty("ascr_step")]
    public virtual wkt_ad_step_detail? wkt_ad_step_detail { get; set; }
}
