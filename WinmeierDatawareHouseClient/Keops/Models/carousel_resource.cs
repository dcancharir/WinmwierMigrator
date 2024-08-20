using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("cr_carousel_id", "cr_resource_id", "cr_position")]
public partial class carousel_resource
{
    [Key]
    public long cr_carousel_id { get; set; }

    [Key]
    public long cr_resource_id { get; set; }

    [Key]
    public int cr_position { get; set; }

    [StringLength(50)]
    public string cr_name { get; set; } = null!;

    [StringLength(1000)]
    public string cr_path { get; set; } = null!;

    public int cr_duration { get; set; }

    public int cr_size { get; set; }
}
