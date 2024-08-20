using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("c2_draw_audit")]
public partial class c2_draw_audit
{
    public long da_draw_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime da_draw_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime da_datetime { get; set; }

    [Column(TypeName = "xml")]
    public string da_winning_numbers { get; set; } = null!;
}
