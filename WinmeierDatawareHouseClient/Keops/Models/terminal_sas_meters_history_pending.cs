using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("terminal_sas_meters_history_pending")]
public partial class terminal_sas_meters_history_pending
{
    [Key]
    public int tsmhp_terminal_id { get; set; }

    public long tsmhp_meter_jackpot_increment_value { get; set; }

    public int tsmhp_meter_jackpot_turns { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tsmhp_created_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tsmhp_update_datetime { get; set; }
}
