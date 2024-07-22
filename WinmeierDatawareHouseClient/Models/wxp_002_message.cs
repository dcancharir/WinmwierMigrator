using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Index("wxm_datetime", Name = "IX_wx2m_datetime", AllDescending = true)]
public partial class wxp_002_message
{
    [Key]
    public long wxm_id { get; set; }

    public int wxm_terminal_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime wxm_datetime { get; set; }

    [StringLength(50)]
    public string? wxm_nuc { get; set; }

    [StringLength(40)]
    public string? wxm_nuid { get; set; }

    [StringLength(50)]
    public string? wxm_serial { get; set; }

    public int wxm_event_id { get; set; }

    [Column(TypeName = "money")]
    public decimal wxm_coin_in { get; set; }

    [Column(TypeName = "money")]
    public decimal wxm_coin_out { get; set; }

    [Column(TypeName = "money")]
    public decimal wxm_jackpot { get; set; }

    [Column(TypeName = "money")]
    public decimal wxm_hand_paid { get; set; }

    [Column(TypeName = "money")]
    public decimal wxm_bill_in { get; set; }

    public long wxm_games_played { get; set; }

    [Column(TypeName = "money")]
    public decimal wxm_payout { get; set; }
}
