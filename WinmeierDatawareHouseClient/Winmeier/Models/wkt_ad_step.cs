using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Index("as_ad_id", Name = "IX_wkt_ad_steps_as_ad_id")]
public partial class wkt_ad_step
{
    [Key]
    public long as_step_id { get; set; }

    public long? as_ad_id { get; set; }

    public int as_step_order { get; set; }

    public int? as_duration { get; set; }
}
