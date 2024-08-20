using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class gui_user_profile
{
    [Key]
    public int gup_profile_id { get; set; }

    [StringLength(40)]
    public string gup_name { get; set; } = null!;

    public byte[]? gup_timestamp { get; set; }

    public int gup_max_users { get; set; }

    public int? gup_master_id { get; set; }

    public long? gup_master_sequence_id { get; set; }

    public bool gup_handpay_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal? gup_handpay_limit_value { get; set; }

    public bool gup_sales_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal? gup_sales_limit_value { get; set; }
}
