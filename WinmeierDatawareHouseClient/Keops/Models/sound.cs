using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class sound
{
    public long sound_id { get; set; }

    [StringLength(200)]
    public string sound_name { get; set; } = null!;

    [StringLength(100)]
    public string sound_extension { get; set; } = null!;

    public long sound_length_msec { get; set; }

    [MaxLength(1)]
    public byte[]? sound_data { get; set; }

    [MaxLength(1)]
    public byte[]? sound_hash { get; set; }

    public bool? sound_deleted { get; set; }

    public long? sound_timestamp { get; set; }
}
