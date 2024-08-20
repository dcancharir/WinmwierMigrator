using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("bh_id", "bh_timestamp")]
public partial class buffer_handpay
{
    [Key]
    public long bh_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime bh_timestamp { get; set; }
}
