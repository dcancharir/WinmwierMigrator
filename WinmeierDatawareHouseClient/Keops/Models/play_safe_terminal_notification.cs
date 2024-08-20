using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("play_safe.terminal_notification")]
public partial class play_safe_terminal_notification
{
    [Key]
    public int pstn_terminal_id { get; set; }

    public long? pstn_last_notified_change_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pstn_last_notified { get; set; }
}
