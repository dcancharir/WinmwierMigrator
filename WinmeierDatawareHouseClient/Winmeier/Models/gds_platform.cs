using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Keyless]
public partial class gds_platform
{
    public long gp_platform_id { get; set; }

    [StringLength(50)]
    public string gp_name { get; set; } = null!;
}
