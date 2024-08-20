using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("gp_group_key", "gp_subject_key")]
public partial class general_param
{
    [Key]
    [StringLength(50)]
    public string gp_group_key { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string gp_subject_key { get; set; } = null!;

    [StringLength(1024)]
    public string? gp_key_value { get; set; }

    [StringLength(2000)]
    public string? gp_description { get; set; }
}
