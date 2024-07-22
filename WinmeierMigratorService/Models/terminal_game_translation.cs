using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("tgt_terminal_id", "tgt_source_game_id")]
[Table("terminal_game_translation")]
public partial class terminal_game_translation
{
    [Key]
    public int tgt_terminal_id { get; set; }

    [Key]
    public int tgt_source_game_id { get; set; }

    public int tgt_target_game_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tgt_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tgt_updated { get; set; }

    public byte[]? tgt_timestamp { get; set; }

    public int? tgt_payout_idx { get; set; }

    public int? tgt_translated_game_id { get; set; }
}
