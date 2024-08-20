using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

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
}
