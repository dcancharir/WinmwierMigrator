using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("alcg_alarm_code", "alcg_language_id")]
[Table("alarm_catalog")]
public partial class alarm_catalog
{
    [Key]
    public int alcg_alarm_code { get; set; }

    [Key]
    public int alcg_language_id { get; set; }

    public int alcg_type { get; set; }

    [StringLength(50)]
    public string alcg_name { get; set; } = null!;

    [StringLength(350)]
    public string? alcg_description { get; set; }

    public int alcg_visible { get; set; }
}
