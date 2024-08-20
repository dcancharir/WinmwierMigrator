using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("terminal_attribute")]
public partial class terminal_attribute
{
    public long ta_id { get; set; }

    public long ta_catalog_id { get; set; }

    public short? ta_order { get; set; }

    public short ta_type { get; set; }

    [StringLength(500)]
    public string? ta_regex { get; set; }
}
