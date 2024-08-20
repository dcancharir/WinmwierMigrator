using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("terminals_pending")]
public partial class terminals_pending
{
    public int tp_id { get; set; }

    public int? tp_source { get; set; }

    [StringLength(100)]
    public string? tp_vendor_id { get; set; }

    [StringLength(100)]
    public string? tp_serial_number { get; set; }

    public int? tp_machine_number { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tp_reported { get; set; }

    public bool tp_ignore { get; set; }

    public short tp_terminal_type { get; set; }
}
