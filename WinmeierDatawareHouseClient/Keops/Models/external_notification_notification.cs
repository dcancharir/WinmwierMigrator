using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class external_notification_notification
{
    public long enn_id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string enn_property_id { get; set; } = null!;

    public int enn_data_type { get; set; }

    public int enn_action_type { get; set; }

    public long enn_identifier_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime enn_created_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? enn_last_notification_datetime { get; set; }

    public int? enn_status { get; set; }

    public int enn_retry_number { get; set; }

    [Unicode(false)]
    public string? enn_data { get; set; }
}
