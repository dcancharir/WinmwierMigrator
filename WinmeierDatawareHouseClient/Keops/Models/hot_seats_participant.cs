using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class hot_seats_participant
{
    public long hsw_id { get; set; }

    public long hsw_hot_seat_execution_id { get; set; }

    public long hsw_hot_seat_id { get; set; }

    public long hsw_account_id { get; set; }

    public long hsw_play_session_id { get; set; }

    public int hsw_terminal_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime hsw_execution_date { get; set; }

    public bool hsw_winner { get; set; }

    public int hsw_prize_type { get; set; }

    public int hsw_prize_count { get; set; }
}
