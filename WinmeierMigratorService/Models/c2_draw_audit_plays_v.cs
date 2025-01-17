using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class c2_draw_audit_plays_v
{
    public long dap_play_id { get; set; }

    public long dap_draw_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dap_play_datetime { get; set; }

    public int dap_terminal_id { get; set; }

    [StringLength(50)]
    public string? dap_terminal_name { get; set; }

    [Column(TypeName = "money")]
    public decimal dap_denomination { get; set; }

    public long dap_played_credits { get; set; }

    public long dap_won_credits { get; set; }

    public long dap_jackpot_bound_credits { get; set; }

    [Column(TypeName = "xml")]
    public string? dap_prize_list { get; set; }

    [Column(TypeName = "xml")]
    public string dap_cards { get; set; } = null!;

    public long dap_wcp_transaction_id { get; set; }

    public int DAP_GAME_ID { get; set; }

    [StringLength(50)]
    public string DAP_GAME_NAME { get; set; } = null!;
}
