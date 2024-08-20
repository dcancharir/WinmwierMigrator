using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class draw_ticket
{
    public long dt_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dt_created { get; set; }

    public long dt_draw_id { get; set; }

    public long dt_account_id { get; set; }

    public long dt_first_number { get; set; }

    public long dt_last_number { get; set; }

    public long? dt_voucher_id { get; set; }

    public bool dt_per_points { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dt_awarded_day { get; set; }

    public byte? dt_auto_print_status { get; set; }

    public long? dt_play_session_id { get; set; }

    public int? dt_origin_draw { get; set; }
}
