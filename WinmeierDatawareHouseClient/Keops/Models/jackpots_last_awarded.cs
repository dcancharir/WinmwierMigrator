using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("jla_jackpot_id", "jla_type")]
[Table("jackpots_last_awarded")]
public partial class jackpots_last_awarded
{
    [Key]
    public long jla_jackpot_id { get; set; }

    [Key]
    public int jla_type { get; set; }

    public long? jla_award_id { get; set; }
}
