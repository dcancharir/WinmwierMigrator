using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("gaming_tables_win_loss")]
public partial class gaming_tables_win_loss
{
    public long gtwl_id { get; set; }

    public long gtwl_gaming_table_session_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gtwl_datetime_hour { get; set; }

    [StringLength(6)]
    public string gtwl_iso_code { get; set; } = null!;

    public int gtwl_cage_currency_type { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtwl_win_loss_amount { get; set; }

    public int gtwl_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gtwl_last_update { get; set; }
}
