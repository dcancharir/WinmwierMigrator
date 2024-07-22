using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Index("gtpm_type", "gtpm_datetime", Name = "IX_gtpm_type_datetime")]
public partial class gt_playertracking_movement
{
    [Key]
    public long gtpm_movement_id { get; set; }

    public int gtpm_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gtpm_datetime { get; set; }

    public int gtpm_user_id { get; set; }

    public long gtpm_cashier_id { get; set; }

    public long gtpm_gaming_table_session_id { get; set; }

    public int gtpm_gaming_table_id { get; set; }

    public long? gtpm_seat_id { get; set; }

    public long? gtpm_play_session_id { get; set; }

    public long? gtpm_terminal_id { get; set; }

    public long? gtpm_account_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtpm_old_value { get; set; }

    [Column(TypeName = "money")]
    public decimal gtpm_value { get; set; }

    [StringLength(3)]
    public string? gtpm_iso_code { get; set; }
}
