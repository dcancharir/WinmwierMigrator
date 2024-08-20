using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class movement_tracking_type
{
    public int mtt_type_id { get; set; }

    [StringLength(100)]
    public string mtt_name { get; set; } = null!;
}
