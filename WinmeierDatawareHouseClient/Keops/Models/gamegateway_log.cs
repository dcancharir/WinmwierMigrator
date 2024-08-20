using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("gamegateway_log")]
public partial class gamegateway_log
{
    public long gl_id { get; set; }

    [Column(TypeName = "xml")]
    public string? gl_request { get; set; }

    [Column(TypeName = "xml")]
    public string? gl_response { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gl_datetime { get; set; }

    public int? gl_terminal_id { get; set; }
}
