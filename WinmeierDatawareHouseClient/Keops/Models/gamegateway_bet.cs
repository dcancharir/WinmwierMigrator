using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("gb_game_id", "gb_game_instance_id", "gb_partner_id", "gb_transaction_type", "gb_transaction_id", "gb_account_id")]
[Index("gb_account_id", "gb_transaction_type", Name = "IX_gb_account_id_gb_transaction_type")]
[Index("gb_transaction_id", "gb_transaction_type", Name = "IX_gb_transaction_id_gb_transaction_type")]
[Index("gb_transaction_type", "gb_account_id", Name = "IX_gb_transaction_type_gb_account_id")]
public partial class gamegateway_bet
{
    [Key]
    public long gb_game_id { get; set; }

    [Key]
    public long gb_game_instance_id { get; set; }

    [Key]
    public int gb_transaction_type { get; set; }

    [Key]
    [StringLength(40)]
    public string gb_transaction_id { get; set; } = null!;

    [Key]
    public long gb_account_id { get; set; }

    [Key]
    public int gb_partner_id { get; set; }

    public int? gb_egm_terminal_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gb_created { get; set; }

    [Column(TypeName = "xml")]
    public string? gb_bets { get; set; }

    public int gb_num_bets { get; set; }

    [Column(TypeName = "money")]
    public decimal gb_total_bet { get; set; }

    public int gb_num_prizes { get; set; }

    [Column(TypeName = "money")]
    public decimal gb_total_prize { get; set; }

    [Column(TypeName = "money")]
    public decimal gb_jackpot_prize { get; set; }

    public long? gb_related_ps_id { get; set; }

    public long? gb_related_mv_id { get; set; }

    public byte[] gb_last_updated { get; set; } = null!;
}
