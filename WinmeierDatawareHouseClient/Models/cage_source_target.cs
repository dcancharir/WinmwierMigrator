using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Table("cage_source_target")]
public partial class cage_source_target
{
    [Key]
    public long cst_source_target_id { get; set; }

    [StringLength(50)]
    public string cst_source_target_name { get; set; } = null!;

    public bool cst_source { get; set; }

    public bool cst_target { get; set; }
}
