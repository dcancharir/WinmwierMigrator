using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("c2_jackpot_history")]
[Index("c2jh_play_id", Name = "IDX_Jackpot_Play_Id")]
public partial class c2_jackpot_history
{
    [Key]
    public long c2jh_jackpot_id { get; set; }

    public int c2jh_index { get; set; }

    [StringLength(20)]
    public string? c2jh_name { get; set; }

    public int c2jh_status { get; set; }

    [Column(TypeName = "money")]
    public decimal c2jh_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime c2jh_awarded { get; set; }

    public long? c2jh_play_id { get; set; }

    public int c2jh_terminal_id { get; set; }

    [StringLength(50)]
    public string? c2jh_terminal_name { get; set; }

    public int c2jh_game_id { get; set; }

    [StringLength(50)]
    public string? c2jh_game_name { get; set; }

    [ForeignKey("c2jh_play_id")]
    [InverseProperty("c2_jackpot_histories")]
    public virtual c2_draw_audit_play? c2jh_play { get; set; }
}
