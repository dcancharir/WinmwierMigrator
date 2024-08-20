using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("dc_date", "dc_type_config_id", "dc_config_id")]
[Table("dates_by_config")]
public partial class dates_by_config
{
    [Key]
    public long dc_type_config_id { get; set; }

    [Key]
    public long dc_config_id { get; set; }

    [Key]
    public int dc_date { get; set; }
}
