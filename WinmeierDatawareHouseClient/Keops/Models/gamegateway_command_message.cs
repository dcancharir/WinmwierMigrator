using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class gamegateway_command_message
{
    public long gcm_id { get; set; }

    public int gcm_terminal_id { get; set; }

    public int gcm_code { get; set; }

    public int gcm_type { get; set; }

    public string? gcm_parameter { get; set; }

    public int gcm_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gcm_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gcm_status_changed { get; set; }

    public string? gcm_response { get; set; }
}
