using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("btc_date", "btc_master_id")]
[Table("buffer_terminals_connected")]
public partial class buffer_terminals_connected
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime btc_date { get; set; }

    [Key]
    public int btc_master_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime btc_timestamp { get; set; }
}
