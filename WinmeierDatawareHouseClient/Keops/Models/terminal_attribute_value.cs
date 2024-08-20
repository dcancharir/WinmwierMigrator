using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("terminal_attribute_value")]
public partial class terminal_attribute_value
{
    public long tav_id { get; set; }

    public int tav_terminal_id { get; set; }

    public long tav_catalog_id { get; set; }

    public long? tav_catalog_item_id { get; set; }

    [StringLength(500)]
    public string? tav_text { get; set; }
}
