using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("jvt_jackpot_viewer_id", "jvt_terminal_viewer_id")]
[Table("jackpots_viewers_related_terminal")]
public partial class jackpots_viewers_related_terminal
{
    [Key]
    public int jvt_jackpot_viewer_id { get; set; }

    [Key]
    public int jvt_terminal_viewer_id { get; set; }
}
