using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class wkt_ad_step
{
    public long as_step_id { get; set; }

    public long? as_ad_id { get; set; }

    public int as_step_order { get; set; }

    public int? as_duration { get; set; }
}
