using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Table("terminals_pending")]
[Index("tp_source", "tp_vendor_id", "tp_serial_number", Name = "IX_tp_source_vendor_sn")]
public partial class terminals_pending
{
    [Key]
    public int tp_id { get; set; }

    public int? tp_source { get; set; }

    [StringLength(50)]
    public string? tp_vendor_id { get; set; }

    [StringLength(50)]
    public string? tp_serial_number { get; set; }

    public int? tp_machine_number { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tp_reported { get; set; }

    public bool tp_ignore { get; set; }

    public short tp_terminal_type { get; set; }
}
