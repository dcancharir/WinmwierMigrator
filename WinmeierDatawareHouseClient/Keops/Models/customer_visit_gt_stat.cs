using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class customer_visit_gt_stat
{
    [Key]
    public long cvgt_visit_id { get; set; }

    public int cvgt_playing_time { get; set; }

    public int? cvgt_site_id { get; set; }

    public byte[]? cvgt_timestamp { get; set; }
}
