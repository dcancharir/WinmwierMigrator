using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class terminal_setting
{
    public int ts_id { get; set; }

    [StringLength(60)]
    public string ts_name { get; set; } = null!;

    [StringLength(200)]
    public string? ts_description { get; set; }

    public int ts_tipo_recaudacion { get; set; }

    public byte[] ts_timestamp { get; set; } = null!;

    public long? ts_master_sequence_id { get; set; }
}
