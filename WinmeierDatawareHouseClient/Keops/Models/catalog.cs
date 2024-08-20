using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Index("cat_enum_name", Name = "IX_cat_enum_name")]
[Index("cat_system_type", "cat_type", Name = "IX_cat_system_type")]
public partial class catalog
{
    [Key]
    public long cat_id { get; set; }

    public short cat_type { get; set; }

    [StringLength(50)]
    public string? cat_name { get; set; }

    [StringLength(250)]
    public string? cat_description { get; set; }

    public bool cat_enabled { get; set; }

    public int? cat_system_type { get; set; }

    [StringLength(50)]
    public string? cat_enum_name { get; set; }
}
