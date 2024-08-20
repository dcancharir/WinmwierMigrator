using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("wps_account_id", "wps_day")]
[Table("wsp_player_spent_by_day")]
public partial class wsp_player_spent_by_day
{
    [Key]
    public long wps_account_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime wps_day { get; set; }

    [Column(TypeName = "money")]
    public decimal wps_amount { get; set; }

    public bool wps_used { get; set; }
}
