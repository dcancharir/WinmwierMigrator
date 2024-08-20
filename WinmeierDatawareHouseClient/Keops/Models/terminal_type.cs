using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Index("tt_name", Name = "IX_terminal_type_name", IsUnique = true)]
public partial class terminal_type
{
    [Key]
    public int tt_type { get; set; }

    [StringLength(50)]
    public string tt_name { get; set; } = null!;
}
