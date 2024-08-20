using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("enttn_movement_type", "enttn_type_code")]
[Table("external_notification_types_to_notify")]
public partial class external_notification_types_to_notify
{
    [Key]
    public int enttn_movement_type { get; set; }

    [Key]
    public int enttn_type_code { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? enttn_description { get; set; }

    public bool enttn_enabled { get; set; }
}
