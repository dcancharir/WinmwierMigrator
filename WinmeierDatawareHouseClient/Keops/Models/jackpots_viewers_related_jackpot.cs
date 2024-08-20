using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("jvj_id", "jvj_jackpot_viewer_id", "jvj_jackpot_id")]
[Table("jackpots_viewers_related_jackpot")]
public partial class jackpots_viewers_related_jackpot
{
    [Key]
    public int jvj_id { get; set; }

    [Key]
    public int jvj_jackpot_viewer_id { get; set; }

    [Key]
    public long jvj_jackpot_id { get; set; }

    public int jvj_order { get; set; }

    public int? jvj_jackpot_type { get; set; }
}
