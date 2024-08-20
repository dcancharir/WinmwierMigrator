using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class sending_instance
{
    public long si_instance_id { get; set; }

    [StringLength(300)]
    public string? si_external_id { get; set; }

    public int si_send_provider { get; set; }

    public string si_send_body { get; set; } = null!;

    [StringLength(1000)]
    public string si_send_to { get; set; } = null!;

    public int si_send_attemps { get; set; }

    public int si_send_status { get; set; }

    public string? si_send_reason_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime si_last_update { get; set; }
}
