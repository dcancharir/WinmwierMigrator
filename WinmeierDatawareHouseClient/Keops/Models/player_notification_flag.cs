using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("pnf_player_notification_configuration_id", "pnf_type", "pnf_flag_id")]
public partial class player_notification_flag
{
    [Key]
    public long pnf_player_notification_configuration_id { get; set; }

    [Key]
    public int pnf_type { get; set; }

    [Key]
    public long pnf_flag_id { get; set; }

    public int? pnf_flag_count { get; set; }

    public int? pnf_flag_count_excluded { get; set; }
}
