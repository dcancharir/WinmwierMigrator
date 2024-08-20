using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("abec_bucket_id", "abec_day_month", "abec_year")]
[Table("account_buckets_expired_control")]
public partial class account_buckets_expired_control
{
    [Key]
    public long abec_bucket_id { get; set; }

    [Key]
    [StringLength(5)]
    public string abec_day_month { get; set; } = null!;

    [Key]
    public int abec_year { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? abec_execution { get; set; }
}
