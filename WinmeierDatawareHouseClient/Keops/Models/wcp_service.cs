using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class wcp_service
{
    public long wsvr_service_id { get; set; }

    [StringLength(100)]
    public string wsvr_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? wsvr_watchdog { get; set; }
}
