using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("wsp_player_recharge")]
public partial class wsp_player_recharge
{
    public long wpr_unique_id { get; set; }

    public long wpr_account_id { get; set; }

    [Column(TypeName = "money")]
    public decimal wpr_nr_amount { get; set; }

    public int wpr_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime wpr_created { get; set; }
}
