using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("bwsvr2_id", "bwsvr2_timestamp")]
public partial class buffer_wc2Session
{
    [Key]
    public long bwsvr2_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime bwsvr2_timestamp { get; set; }
}
