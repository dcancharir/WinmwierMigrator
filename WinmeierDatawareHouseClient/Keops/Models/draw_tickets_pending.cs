using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("draw_tickets_pending")]
public partial class draw_tickets_pending
{
    public long dtp_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dtp_created { get; set; }

    public long dtp_draw_id { get; set; }

    public long dtp_pos_id { get; set; }

    public long dtp_account_id { get; set; }

    public long dtp_number { get; set; }

    public int? dtp_numbers_per_voucher { get; set; }

    public long? dtp_play_session_id { get; set; }

    public int? dtp_origin_draw { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dtp_awarded_day { get; set; }

    public bool? dtp_per_points { get; set; }

    public byte? dtp_auto_print_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dtp_expiry_date { get; set; }
}
