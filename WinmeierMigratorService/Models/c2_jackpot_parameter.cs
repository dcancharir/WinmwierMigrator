using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class c2_jackpot_parameter
{
    public bool c2jp_enabled { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal c2jp_contribution_pct { get; set; }

    public int c2jp_awarding_days { get; set; }

    public int c2jp_awarding_start { get; set; }

    public int c2jp_awarding_end { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal c2jp_compensation_pct { get; set; }

    public byte[] c2jp_timestamp { get; set; } = null!;

    public int c2jp_block_mode { get; set; }

    [Column(TypeName = "money")]
    public decimal c2jp_block_min_amount { get; set; }

    public int c2jp_block_interval { get; set; }

    public int c2jp_animation_interval { get; set; }

    public int c2jp_recent_interval { get; set; }

    public string? c2jp_promo_message1 { get; set; }

    public string? c2jp_promo_message2 { get; set; }

    public string? c2jp_promo_message3 { get; set; }
}
