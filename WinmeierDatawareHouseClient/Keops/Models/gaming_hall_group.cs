using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("ghg_collection_group_id", "ghg_mc_collection_id")]
[Table("gaming_hall_group")]
public partial class gaming_hall_group
{
    [Key]
    public long ghg_collection_group_id { get; set; }

    [Key]
    public long ghg_mc_collection_id { get; set; }
}
