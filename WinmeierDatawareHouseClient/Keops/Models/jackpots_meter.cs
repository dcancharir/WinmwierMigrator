using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("jm_jackpot_id", "jm_date_time")]
public partial class jackpots_meter
{
    [Key]
    public int jm_jackpot_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime jm_date_time { get; set; }

    [Column(TypeName = "numeric(20, 8)")]
    public decimal jm_meter_amount { get; set; }
}
