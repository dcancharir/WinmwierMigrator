using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("alcc_alarm_code", "alcc_category")]
[Table("alarm_catalog_per_category")]
public partial class alarm_catalog_per_category
{
    [Key]
    public int alcc_alarm_code { get; set; }

    [Key]
    public int alcc_category { get; set; }

    public int alcc_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime alcc_datetime { get; set; }
}
