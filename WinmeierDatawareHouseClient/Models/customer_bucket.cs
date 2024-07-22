using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("cbu_customer_id", "cbu_bucket_id")]
[Table("customer_bucket")]
public partial class customer_bucket
{
    [Key]
    public long cbu_customer_id { get; set; }

    [Key]
    public long cbu_bucket_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? cbu_value { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cbu_updated { get; set; }

    public byte[]? cbu_timestamp { get; set; }
}
