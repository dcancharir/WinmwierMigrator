using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("gaming_tables_tournament_prize")]
public partial class gaming_tables_tournament_prize
{
    public long gttp_prize_id { get; set; }

    public long gttp_tournament_id { get; set; }

    public long gttp_account_id { get; set; }

    public int gttp_ranking { get; set; }

    public int gttp_status { get; set; }

    [Column(TypeName = "money")]
    public decimal gttp_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gttp_award_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gttp_payment_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gttp_expiration_date { get; set; }

    public long? gttp_operation_id { get; set; }
}
