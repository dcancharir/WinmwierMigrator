using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("smcg_group_id", "smcg_meter_code")]
[Table("sas_meters_catalog_per_group")]
[Index("smcg_meter_code", Name = "IX_sas_meters_catalog_per_group_smcg_meter_code")]
public partial class sas_meters_catalog_per_group
{
    [Key]
    public int smcg_group_id { get; set; }

    [Key]
    public int smcg_meter_code { get; set; }
}
