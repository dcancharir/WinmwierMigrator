using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("bwsvr_id", "bwsvr_timestamp")]
public partial class buffer_wcpSession
{
    [Key]
    public long bwsvr_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime bwsvr_timestamp { get; set; }
}
