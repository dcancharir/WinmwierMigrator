using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("customer_preferences_catalog")]
public partial class customer_preferences_catalog
{
    public long cpc_id { get; set; }

    public long cpc_catalog_item_group_id { get; set; }

    public long cpc_catalog_option_id { get; set; }

    [StringLength(500)]
    public string cpc_name { get; set; } = null!;

    public int cpc_available_in { get; set; }

    public bool cpc_mandatory { get; set; }

    public int cpc_status { get; set; }

    public string? cpc_description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cpc_last_update { get; set; }
}
