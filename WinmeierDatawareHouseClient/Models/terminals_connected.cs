using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("tc_date", "tc_master_id")]
[Table("terminals_connected")]
public partial class terminals_connected
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime tc_date { get; set; }

    [Key]
    public int tc_master_id { get; set; }

    public int tc_terminal_id { get; set; }

    public int tc_status { get; set; }

    public bool tc_connected { get; set; }

    public byte[] tc_timestamp { get; set; } = null!;
}
