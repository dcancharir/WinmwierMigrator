using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class terminals_last_play_session
{
    public int lp_terminal_id { get; set; }

    public long? lp_play_session_id { get; set; }
}
