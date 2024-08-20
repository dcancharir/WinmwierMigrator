using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("apd_play_session_id", "apd_account_promotion_id", "apd_transaction_id")]
[Table("account_promotion_downloaded")]
[Index("apd_account_promotion_id", Name = "IX_account_promotion_downloaded_apd_account_promotion_id")]
public partial class account_promotion_downloaded
{
    [Key]
    public long apd_play_session_id { get; set; }

    [Key]
    public long apd_account_promotion_id { get; set; }

    [Key]
    public long apd_transaction_id { get; set; }

    [Column(TypeName = "money")]
    public decimal apd_balance_downloaded { get; set; }
}
