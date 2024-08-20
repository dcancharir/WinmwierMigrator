using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("customer_notices_history")]
public partial class customer_notices_history
{
    public long cnh_notice_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cnh_datetime { get; set; }

    public int cnh_user_id { get; set; }

    public int cnh_priority_id { get; set; }

    public int cnh_status { get; set; }

    [StringLength(250)]
    public string cnh_text { get; set; } = null!;

    [StringLength(25)]
    public string cnh_header { get; set; } = null!;
}
