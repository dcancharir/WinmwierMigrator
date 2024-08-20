using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("BGL_ACCOUNT_ID", "BGL_GAME_ID")]
[Table("BONUSING_GAMES_LIMITS")]
public partial class BONUSING_GAMES_LIMIT
{
    [Key]
    public long BGL_ACCOUNT_ID { get; set; }

    [Key]
    public long BGL_GAME_ID { get; set; }

    public int BGL_WORKINGDAY { get; set; }

    public byte BGL_MONTH { get; set; }

    [Column(TypeName = "money")]
    public decimal? BGL_WORKINGDAY_LIMIT { get; set; }

    [Column(TypeName = "money")]
    public decimal? BGL_MONTHLY_LIMIT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BGL_UPDATE_DATETIME { get; set; }
}
