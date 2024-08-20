using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class credit_line_movement
{
    public long clm_id { get; set; }

    public long clm_credit_line_id { get; set; }

    public long clm_operation_id { get; set; }

    public int clm_type { get; set; }

    [Column(TypeName = "xml")]
    public string? clm_old_value { get; set; }

    [Column(TypeName = "xml")]
    public string clm_new_value { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime clm_creation { get; set; }

    [StringLength(100)]
    public string clm_creation_user { get; set; } = null!;

    public byte[] clm_timestamp { get; set; } = null!;
}
