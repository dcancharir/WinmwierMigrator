using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("cmd_ps_id", Name = "IX_ps_cmd")]
[Index("cmd_status", Name = "IX_status")]
[Index("cmd_status", "cmd_terminal_id", "cmd_code", Name = "IX_status_terminal_cmd")]
public partial class wcp_command
{
    [Key]
    public long cmd_id { get; set; }

    public int cmd_terminal_id { get; set; }

    public int cmd_code { get; set; }

    [StringLength(2000)]
    public string? cmd_parameter { get; set; }

    public int cmd_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cmd_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cmd_status_changed { get; set; }

    public string? cmd_response { get; set; }

    public long? cmd_ps_id { get; set; }
}
