using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class draws_launch_parameter
{
    public long dlp_id { get; set; }

    public long? dlp_draw_id { get; set; }

    public bool dlp_actively_playing { get; set; }

    public bool dlp_condition_and_or { get; set; }

    public bool dlp_earn_requirement { get; set; }

    [Column(TypeName = "money")]
    public decimal? dlp_minimun_earned { get; set; }

    public int? dlp_requirement_type { get; set; }

    public int? dlp_schedule_earned_before { get; set; }

    public int? dlp_schedule_type { get; set; }

    public bool dlp_include_previous_winners { get; set; }

    public int dlp_pick_n_winners { get; set; }

    public bool dlp_display_message_on_tv { get; set; }

    [StringLength(1000)]
    public string? dlp_before_draw_text { get; set; }

    public short dlp_before_draw_time { get; set; }

    public bool dlp_during_draw_enabled { get; set; }

    [StringLength(1000)]
    public string? dlp_during_draw_text { get; set; }

    public bool dlp_after_draw_enabled { get; set; }

    [StringLength(1000)]
    public string? dlp_after_draw_text { get; set; }
}
