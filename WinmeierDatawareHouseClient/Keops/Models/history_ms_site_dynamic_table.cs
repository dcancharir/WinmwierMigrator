using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("hmsdt_site_id", "hmsdt_related_task_id", "hmsdt_table_name")]
public partial class history_ms_site_dynamic_table
{
    [Key]
    public int hmsdt_site_id { get; set; }

    [Key]
    public int hmsdt_related_task_id { get; set; }

    [Key]
    [StringLength(80)]
    public string hmsdt_table_name { get; set; } = null!;

    public long? hmsdt_site_sequence_id { get; set; }

    public long? hmsdt_multisite_sequence_id { get; set; }

    public int? hmsdt_num_pending { get; set; }

    public byte[]? hmsdt_timestamp { get; set; }
}
