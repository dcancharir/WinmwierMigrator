using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_externallog
{
    public long lel_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime lel_datetime { get; set; }

    [StringLength(500)]
    public string? lel_source { get; set; }

    [StringLength(500)]
    public string? lel_device_id { get; set; }

    public int lel_user_id { get; set; }

    [MaxLength(1)]
    public byte[]? lel_content { get; set; }
}
