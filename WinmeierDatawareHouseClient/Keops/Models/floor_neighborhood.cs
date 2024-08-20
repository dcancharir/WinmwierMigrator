using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("fn_tid1", "fn_tid2")]
[Table("floor_neighborhood")]
[Index("fn_tid1", Name = "idx_floor_neigh_tid1")]
[Index("fn_tid2", Name = "idx_floor_neigh_tid2")]
public partial class floor_neighborhood
{
    [Key]
    public int fn_tid1 { get; set; }

    [Key]
    public int fn_tid2 { get; set; }

    public bool? fn_exclude { get; set; }
}
