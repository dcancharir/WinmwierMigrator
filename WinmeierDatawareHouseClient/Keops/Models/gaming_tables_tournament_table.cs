using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("gttt_tournament_id", "gttt_gaming_table_id")]
public partial class gaming_tables_tournament_table
{
    [Key]
    public long gttt_tournament_id { get; set; }

    [Key]
    public int gttt_gaming_table_id { get; set; }
}
