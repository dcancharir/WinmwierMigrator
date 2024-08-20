using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class layout_parameter
{
    [Key]
    public int lp_id { get; set; }

    [StringLength(50)]
    public string? lp_group { get; set; }

    [StringLength(250)]
    public string lp_desc { get; set; } = null!;

    public string lp_value { get; set; } = null!;
}
