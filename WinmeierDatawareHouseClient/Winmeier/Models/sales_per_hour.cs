using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

//[Keyless]
[Table("sales_per_hour")]
[Index("sph_base_hour", Name = "IX_sph_base_hour")]
[Index("sph_unique_id", Name = "IX_sph_unique_id")]
[Index("sph_base_hour", "sph_terminal_id", "sph_game_id", Name = "PK_sales_per_hour", IsUnique = true)]
public partial class sales_per_hour
{
    [Column(TypeName = "datetime")]
    public DateTime sph_base_hour { get; set; }

    public int sph_terminal_id { get; set; }

    [StringLength(50)]
    public string? sph_terminal_name { get; set; }

    public int sph_game_id { get; set; }

    [StringLength(50)]
    public string sph_game_name { get; set; } = null!;

    public long sph_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal sph_played_amount { get; set; }

    public long sph_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal sph_won_amount { get; set; }

    public short sph_num_active_terminals { get; set; }

    public long sph_last_play_id { get; set; }

    public byte[]? sph_timestamp { get; set; }

    [Column(TypeName = "money")]
    public decimal sph_theoretical_won_amount { get; set; }
    [Key]
    public long sph_unique_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? sph_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? sph_progressive_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? sph_progressive_jackpot_amount_0 { get; set; }

    [Column(TypeName = "money")]
    public decimal? sph_progressive_provision_amount { get; set; }
}
