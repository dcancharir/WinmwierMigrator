using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Keyless]
public partial class licence
{
    public int wl_id { get; set; }

    [Column(TypeName = "xml")]
    public string wl_licence { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime wl_insertion_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wl_expiration_date { get; set; }
}
