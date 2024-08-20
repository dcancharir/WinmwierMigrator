using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class wcp_command
{
    public long cmd_id { get; set; }

    public int cmd_terminal_id { get; set; }

    public int cmd_code { get; set; }

    [StringLength(4000)]
    public string? cmd_parameter { get; set; }

    public int cmd_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cmd_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cmd_status_changed { get; set; }

    public string? cmd_response { get; set; }

    public long? cmd_ps_id { get; set; }
}
