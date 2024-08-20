using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Keyless]
[Table("TABLESIZE")]
public partial class TABLESIZE
{
    [StringLength(100)]
    [Unicode(false)]
    public string? NAM { get; set; }

    public int? ROWS { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? RES { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? DATA { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? IND_SZE { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? UNSED { get; set; }
}
