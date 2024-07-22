using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class gt_seat
{
    [Key]
    public long gts_seat_id { get; set; }

    public int gts_gaming_table_id { get; set; }

    public bool gts_enabled { get; set; }

    public int gts_terminal_id { get; set; }

    public long gts_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gts_enabled_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gts_disabled_date { get; set; }

    public int? gts_position { get; set; }

    public long? gts_current_play_session_id { get; set; }
}
