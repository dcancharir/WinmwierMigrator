using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("jackpots_settings_prize_sharing")]
public partial class jackpots_settings_prize_sharing
{
    public int jps_id { get; set; }

    public int jps_jackpot_id { get; set; }

    public bool jps_enabled { get; set; }

    [Column(TypeName = "money")]
    public decimal jps_minimum { get; set; }

    [Column(TypeName = "money")]
    public decimal jps_maximum { get; set; }

    public bool jps_include_winner { get; set; }

    public bool jps_to_same_bank { get; set; }

    public bool jps_to_same_area { get; set; }

    public bool jps_to_same_jackpot { get; set; }

    public int? jps_max_num_of_winners { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? jps_last_update { get; set; }
}
