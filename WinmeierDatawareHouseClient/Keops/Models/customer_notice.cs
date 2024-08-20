using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class customer_notice
{
    public long cn_notice_id { get; set; }

    public long cn_customer_id { get; set; }

    public long cn_priority_id { get; set; }

    public int cn_status { get; set; }

    [StringLength(50)]
    public string cn_header { get; set; } = null!;

    [StringLength(500)]
    public string cn_text { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime cn_creation_date { get; set; }

    public int cn_creation_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cn_last_update_date { get; set; }

    public int? cn_last_update_user_id { get; set; }

    public byte[] cn_timestamp { get; set; } = null!;
}
