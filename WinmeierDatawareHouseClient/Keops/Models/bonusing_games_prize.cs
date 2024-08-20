using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("bgp_bonusing_id", "bgp_item_id")]
[Table("bonusing_games_prize")]
public partial class bonusing_games_prize
{
    [Key]
    public long bgp_bonusing_id { get; set; }

    [Key]
    public int bgp_item_id { get; set; }

    public int bgp_Enabled { get; set; }

    [Column(TypeName = "money")]
    public decimal bgp_Probability { get; set; }

    [Column(TypeName = "money")]
    public decimal bgp_Fixed { get; set; }

    [Column(TypeName = "money")]
    public decimal bgp_Percentage { get; set; }

    public int? bgp_PrizeType { get; set; }
}
