using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("terminal_meter_delta_description")]
public partial class terminal_meter_delta_description
{
    public long tmdd_id { get; set; }

    [StringLength(200)]
    public string tmdd_field_name { get; set; } = null!;

    [StringLength(200)]
    public string tmdd_field_description { get; set; } = null!;

    public int tmdd_group { get; set; }

    public int tmdd_order { get; set; }
}
