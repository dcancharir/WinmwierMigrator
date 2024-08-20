using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class gaming_tables_type
{
    public int gtt_gaming_table_type_id { get; set; }

    [StringLength(100)]
    public string gtt_name { get; set; } = null!;

    public bool gtt_enabled { get; set; }

    public int? gtt_report_type_id { get; set; }
}
