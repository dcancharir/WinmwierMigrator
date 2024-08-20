using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("jackpots_award_detail")]
public partial class jackpots_award_detail
{
    public long jad_id { get; set; }

    public long jad_award_id { get; set; }

    public int jad_position { get; set; }

    public int jad_status { get; set; }

    [Column(TypeName = "money")]
    public decimal jad_amount { get; set; }

    public int? jad_terminal_id { get; set; }

    public long? jad_account_id { get; set; }

    public int? jad_retries { get; set; }

    public long? jad_bonus_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jad_date_award { get; set; }

    public long? jad_play_session_id { get; set; }

    public long? jad_transaction_id { get; set; }

    public byte? jad_type { get; set; }
}
