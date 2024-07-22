using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("cbud_gaming_day", "cbud_customer_id", "cbud_bucket_id")]
[Table("customer_bucket_by_gaming_day")]
public partial class customer_bucket_by_gaming_day
{
    [Key]
    public int cbud_gaming_day { get; set; }

    [Key]
    public long cbud_customer_id { get; set; }

    [Key]
    public long cbud_bucket_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? cbud_value { get; set; }

    [Column(TypeName = "money")]
    public decimal? cbud_value_added { get; set; }

    [Column(TypeName = "money")]
    public decimal? cbud_value_substracted { get; set; }
}
