using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("play_safe.terminal_status")]
[Index("psts_notification_pending", Name = "IX_psts_notification_pending")]
public partial class play_safe_terminal_status
{
    [Key]
    public int psts_terminal_id { get; set; }

    public short? psts_playing { get; set; }

    public long? psts_playing_account_id { get; set; }

    public long? psts_playing_session_id { get; set; }

    public short? psts_reserved { get; set; }

    public long? psts_reserved_account_id { get; set; }

    public long? psts_reserved_trx_id { get; set; }

    public short? psts_blocked { get; set; }

    public short? psts_neighbor_playing { get; set; }

    public short? psts_neighbor_reserved { get; set; }

    public short? psts_clean_pending { get; set; }

    public short? psts_toggle { get; set; }

    public short? psts_final_status_code { get; set; }

    [StringLength(50)]
    public string? psts_final_status_text { get; set; }

    public short? psts_final_pending_notification { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? psts_final_notified { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? psts_final_updated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? psts_final_changed { get; set; }

    public long psts_current_change_id { get; set; }

    public long psts_notified_change_id { get; set; }

    public int psts_notification_pending { get; set; }

    public long? psts_clean_pending_account_id { get; set; }

    public int? psts_card_type { get; set; }

    [StringLength(50)]
    public string? psts_trackdata { get; set; }
}
