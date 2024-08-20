using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class customer_visit
{
    public long cut_visit_id { get; set; }

    public int cut_gaming_day { get; set; }

    public long cut_customer_id { get; set; }

    public int cut_level { get; set; }

    public bool cut_is_vip { get; set; }

    public byte? cut_age { get; set; }

    public byte? cut_gender { get; set; }

    public int? cut_site_id { get; set; }

    public int? cut_time_on_site { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cut_start_time { get; set; }

    public byte[]? cut_timestamp { get; set; }

    public int? cut_venue_id { get; set; }
}
