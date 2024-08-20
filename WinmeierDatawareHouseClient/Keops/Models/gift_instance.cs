using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class gift_instance
{
    public long gin_gift_instance_id { get; set; }

    public long gin_oper_request_id { get; set; }

    public long? gin_oper_delivery_id { get; set; }

    public long gin_account_id { get; set; }

    public long gin_gift_id { get; set; }

    [StringLength(100)]
    public string gin_gift_name { get; set; } = null!;

    public int gin_gift_type { get; set; }

    [Column(TypeName = "money")]
    public decimal gin_points { get; set; }

    [Column(TypeName = "money")]
    public decimal? gin_conversion_to_nrc { get; set; }

    [Column(TypeName = "money")]
    public decimal gin_spent_points { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gin_requested { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gin_delivered { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gin_expiration { get; set; }

    public int gin_request_status { get; set; }

    public int gin_num_items { get; set; }

    public long? gin_data_01 { get; set; }

    public int? gin_notification { get; set; }

    public byte[] gin_row_version { get; set; } = null!;
}
