using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("abel_bucket_id", "abel_account_id")]
[Table("account_buckets_expired_list")]
public partial class account_buckets_expired_list
{
    [Key]
    public long abel_bucket_id { get; set; }

    [Key]
    public long abel_account_id { get; set; }

    [Column(TypeName = "money")]
    public decimal abel_value_to_expire { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime abel_datetime { get; set; }
}
