using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Table("c2_draw_audit")]
[Index("da_draw_datetime", Name = "IX_Draw_Datetime")]
public partial class c2_draw_audit
{
    [Key]
    public long da_draw_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime da_draw_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime da_datetime { get; set; }

    [Column(TypeName = "xml")]
    public string da_winning_numbers { get; set; } = null!;
}
