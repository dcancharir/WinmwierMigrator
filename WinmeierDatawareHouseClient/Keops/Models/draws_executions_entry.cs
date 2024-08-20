using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class draws_executions_entry
{
    public long dee_id { get; set; }

    public long dee_draw_executions_id { get; set; }

    public long dee_account_id { get; set; }

    public long? dee_play_session_id { get; set; }

    public bool dee_is_winner { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dee_datetime { get; set; }

    public long? dee_draw_ticket_id { get; set; }

    public bool dee_is_notified { get; set; }
}
