using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("tm_terminal_id", "tm_transaction_id")]
[Table("terminal_money")]
[Index("tm_cashier_session_id", "tm_amount", "tm_terminal_id", Name = "IX_tm_cashier_session_amount_terminal")]
[Index("tm_cashier_session_id", "tm_terminal_id", Name = "IX_tm_cashier_session_terminal")]
[Index("tm_reported", Name = "IX_tm_reported")]
[Index("tm_terminal_id", "tm_amount", "tm_collection_id", Name = "IX_tm_terminal_amount_collection")]
[Index("tm_trackdata", Name = "IX_tm_trackdata")]
public partial class terminal_money
{
    [Key]
    public int tm_terminal_id { get; set; }

    [Key]
    public long tm_transaction_id { get; set; }

    public long? tm_stacker_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tm_accepted { get; set; }

    [Column(TypeName = "money")]
    public decimal tm_amount { get; set; }

    [StringLength(20)]
    public string tm_trackdata { get; set; } = null!;

    public long? tm_play_session_id { get; set; }

    public long? tm_account_id { get; set; }

    public long? tm_transferred_to_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tm_reported { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tm_transferred { get; set; }

    public long? tm_collection_id { get; set; }

    public bool? tm_into_acceptor { get; set; }

    public long? tm_cashier_session_id { get; set; }
}
