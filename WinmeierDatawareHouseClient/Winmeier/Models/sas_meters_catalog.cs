using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Table("sas_meters_catalog")]
public partial class sas_meters_catalog
{
    [Key]
    public int smc_meter_code { get; set; }

    public string smc_description { get; set; } = null!;

    public int smc_recomended { get; set; }

    public int? smc_required { get; set; }

    [StringLength(200)]
    public string? smc_name { get; set; }
}
