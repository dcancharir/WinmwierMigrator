using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

public partial class ms_pending_game_play_session
{
    [Key]
    public long mps_play_session_id { get; set; }

    public int mps_status { get; set; }
}
