using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class play
{
    public long pl_play_id { get; set; }

    public long? pl_play_session_id { get; set; }

    public long? pl_account_id { get; set; }

    public int pl_terminal_id { get; set; }

    public long pl_wcp_sequence_id { get; set; }

    public long pl_wcp_transaction_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pl_datetime { get; set; }

    public int pl_game_id { get; set; }

    [Column(TypeName = "money")]
    public decimal pl_initial_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal pl_played_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal pl_won_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal pl_final_balance { get; set; }

    public bool? pl_transferred { get; set; }

    public int? pl_num_plays { get; set; }
}
