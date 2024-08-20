using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("mm_meter_id", "mm_cash_type", "mm_money_type", "mm_face_value")]
public partial class money_meter
{
    [Key]
    public long mm_meter_id { get; set; }

    /// <summary>
    /// 1-CashIn, 2-CashOut
    /// </summary>
    [Key]
    public int mm_cash_type { get; set; }

    /// <summary>
    /// 1-Note, 2-Coin
    /// </summary>
    [Key]
    public int mm_money_type { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal mm_face_value { get; set; }

    public int mm_count { get; set; }

    [Column(TypeName = "money")]
    public decimal mm_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mm_last_reported { get; set; }

    public byte[]? mm_timestamp { get; set; }
}
