using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_enum
{
    public long? le_id { get; set; }

    public long? le_level_1 { get; set; }

    public long? le_level_2 { get; set; }

    [StringLength(250)]
    public string? le_description { get; set; }

    [StringLength(50)]
    public string? le_param_1 { get; set; }

    [StringLength(50)]
    public string? le_param_2 { get; set; }

    public long? le_param_3 { get; set; }

    public long? le_param_4 { get; set; }
}
