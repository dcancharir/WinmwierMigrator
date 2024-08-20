using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Index("cai_catalog_id", "cai_catalog_item_id", Name = "IX_cai_item_id", IsUnique = true)]
public partial class catalog_item
{
    [Key]
    public long cai_id { get; set; }

    public long cai_catalog_id { get; set; }

    [StringLength(50)]
    public string? cai_name { get; set; }

    [StringLength(250)]
    public string? cai_description { get; set; }

    public bool cai_enabled { get; set; }

    public long? cai_enum_item_id { get; set; }

    public long cai_catalog_item_id { get; set; }
}
