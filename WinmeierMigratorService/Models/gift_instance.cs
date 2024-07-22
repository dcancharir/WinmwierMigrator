using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("gin_account_id", "gin_gift_type", "gin_requested", Name = "IX_gin_account_type_requested")]
[Index("gin_gift_id", "gin_requested", Name = "IX_gin_gift_id_requested")]
[Index("gin_request_status", Name = "IX_gin_request_status")]
public partial class gift_instance
{
    [Key]
    public long gin_gift_instance_id { get; set; }

    public long gin_oper_request_id { get; set; }

    public long? gin_oper_delivery_id { get; set; }

    public long gin_account_id { get; set; }

    public long gin_gift_id { get; set; }

    [StringLength(50)]
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
}
