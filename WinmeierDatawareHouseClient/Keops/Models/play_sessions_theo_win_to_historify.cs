using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("psth_play_session_id", "psth_play_session_type")]
[Table("play_sessions_theo_win_to_historify")]
[Index("psth_patron_id", Name = "IX_patron_id")]
[Index("psth_theo_win_egm", "psth_theo_win_gt", Name = "IX_win_egm_win_gt")]
public partial class play_sessions_theo_win_to_historify
{
    [Key]
    public long psth_play_session_id { get; set; }

    [Key]
    public int psth_play_session_type { get; set; }

    [Column(TypeName = "money")]
    public decimal? psth_theo_win_egm { get; set; }

    [Column(TypeName = "money")]
    public decimal? psth_theo_win_gt { get; set; }

    public long psth_patron_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime psth_finished_datetime { get; set; }

    public byte[] psth_timestamp { get; set; } = null!;
}
