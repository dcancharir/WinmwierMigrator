using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Keyless]
[Table("Resultado_size")]
public partial class Resultado_size
{
    [StringLength(100)]
    [Unicode(false)]
    public string? NAM { get; set; }

    public int? ROWS { get; set; }

    public int? RES { get; set; }

    public int? DATA { get; set; }

    public int? IND_SZE { get; set; }

    public int? UNSED { get; set; }
}
