using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class draw_pending_tickets_notification
{
    public long dptn_id { get; set; }

    public long dptn_account_id { get; set; }

    public long dptn_draw_id { get; set; }

    [StringLength(100)]
    public string dptn_draw_name { get; set; } = null!;

    public long dptn_draw_new_entries { get; set; }

    public long dptn_draw_total_entries { get; set; }
}
