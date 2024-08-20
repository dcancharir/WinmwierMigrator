using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("food_beverage_instances_sync")]
public partial class food_beverage_instances_sync
{
    public long fbis_id { get; set; }

    public int? fbis_catalog_inserted { get; set; }

    public int? fbis_catalog_updated { get; set; }

    public int? fbis_catalog_deleted { get; set; }

    [StringLength(100)]
    public string? fbis_sync_inserted_by { get; set; }

    public int fbis_sync_status { get; set; }

    public int? fbis_sync_attemps { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fbis_sync_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fbis_created_date { get; set; }
}
