using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Keyless]
public partial class customer_visit_gt_stat
{
    public long cvgt_visit_id { get; set; }

    public int cvgt_playing_time { get; set; }
}
