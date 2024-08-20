using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("terminal_error_code")]
public partial class terminal_error_code
{
    public int tec_id { get; set; }

    public int tec_terminal_id { get; set; }

    public int tec_error_code_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tec_date_created { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string tec_comments { get; set; } = null!;
}
