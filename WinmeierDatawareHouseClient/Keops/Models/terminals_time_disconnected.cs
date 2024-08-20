using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("ttd_site_id", "ttd_terminal_id", "ttd_working_day")]
[Table("terminals_time_disconnected")]
public partial class terminals_time_disconnected
{
    [Key]
    public long ttd_site_id { get; set; }

    [Key]
    public int ttd_terminal_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime ttd_working_day { get; set; }

    public int ttd_egm_collector_seconds { get; set; }

    public int ttd_collector_center_seconds { get; set; }
}
