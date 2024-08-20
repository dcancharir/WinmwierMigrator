using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class mobibank_device
{
    public int mbd_id { get; set; }

    [StringLength(20)]
    public string mbd_code { get; set; } = null!;

    [StringLength(100)]
    public string? mbd_name { get; set; }

    public bool? mbd_status { get; set; }

    [StringLength(100)]
    public string? mbd_aid { get; set; }

    public long? mbd_runner_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mbd_last_activity { get; set; }

    public bool? mbd_runner_status { get; set; }
}
