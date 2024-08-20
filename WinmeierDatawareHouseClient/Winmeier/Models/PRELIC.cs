using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Keyless]
[Table("PRELIC")]
public partial class PRELIC
{
    [Column(TypeName = "xml")]
    public string? wl_licence { get; set; }
}
