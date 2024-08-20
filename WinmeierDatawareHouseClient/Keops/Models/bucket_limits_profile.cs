using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("bucket_limits_profile")]
public partial class bucket_limits_profile
{
    [Key]
    public long blp_id { get; set; }

    public long blp_bucket_id { get; set; }

    public long blp_profile_id { get; set; }

    public bool blp_permission_add { get; set; }

    public bool blp_permission_set { get; set; }

    public bool blp_permission_subtract { get; set; }

    [Column(TypeName = "money")]
    public decimal? blp_limit_day { get; set; }

    [Column(TypeName = "money")]
    public decimal? blp_limit_player { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime blp_datetime { get; set; }
}
