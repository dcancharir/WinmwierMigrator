using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class ms_site_task
{
    [Key]
    public int st_task_id { get; set; }

    public bool st_enabled { get; set; }

    public bool st_running { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? st_started { get; set; }

    public long? st_local_sequence_id { get; set; }

    public long? st_remote_sequence_id { get; set; }

    public int? st_interval_seconds { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? st_last_run { get; set; }

    public int? st_num_pending { get; set; }

    public int st_max_rows_to_upload { get; set; }

    public int st_start_time { get; set; }
}
