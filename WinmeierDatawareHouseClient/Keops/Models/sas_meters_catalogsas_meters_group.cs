using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("smcg_group_id", "smcg_meter_code")]
[Table("sas_meters_catalogsas_meters_group", Schema = "guest")]
public partial class sas_meters_catalogsas_meters_group
{
    [Key]
    public int smcg_group_id { get; set; }

    [Key]
    public int smcg_meter_code { get; set; }
}
