using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class wxp_001_message
{
    public long wxm_id { get; set; }

    public int wxm_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime wxm_datetime { get; set; }

    public int wxm_type { get; set; }

    public int wxm_terminal_id { get; set; }

    [MaxLength(1)]
    public byte[] wxm_data { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime wxm_status_changed { get; set; }
}
