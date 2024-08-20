using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("MIGRATION.TABLES")]
public partial class MIGRATION_TABLE
{
    [StringLength(128)]
    public string TABLE_NAME { get; set; } = null!;

    [StringLength(128)]
    public string? COLUMN_NAME { get; set; }

    [StringLength(200)]
    public string? INDEX_NAME { get; set; }

    public long? NUM_TOP { get; set; }

    public long? NUM_UPDATED { get; set; }

    public long? TOTAL_ELAPSED { get; set; }

    public long? LAST_ELAPSED { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LAST_EXECUTED { get; set; }

    public bool? FINISHED { get; set; }

    public int? TABLE_ORDER { get; set; }
}
