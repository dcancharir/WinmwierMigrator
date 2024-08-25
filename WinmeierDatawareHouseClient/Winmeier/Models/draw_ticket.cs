using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

//[Keyless]
[Index("dt_draw_id", "dt_account_id", "dt_created", Name = "IX_draw_id")]
[Index("dt_account_id", "dt_created", Name = "IX_draw_ticket_account_created")]
[Index("dt_created", Name = "IX_draw_ticket_created")]
[Index("dt_voucher_id", Name = "IX_draw_ticket_voucher_id")]
[Index("dt_first_number", Name = "IX_first_number")]
[Index("dt_id", Name = "IX_id")]
[Index("dt_last_number", Name = "IX_last_number")]
public partial class draw_ticket
{
    [Key]
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
}
