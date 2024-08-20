using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("player_notification")]
public partial class player_notification
{
    public long pn_id { get; set; }

    public long pn_account_id { get; set; }

    public int pn_alarm_code { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pn_datetime { get; set; }

    public int pn_terminal_id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string pn_source_name { get; set; } = null!;
}
