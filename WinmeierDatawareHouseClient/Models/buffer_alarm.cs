using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("ba_id", "ba_timestamp")]
public partial class buffer_alarm
{
    [Key]
    public long ba_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime ba_timestamp { get; set; }
}
