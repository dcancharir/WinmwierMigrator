using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class player_level_icon
{
    public int pli_id { get; set; }

    public int pli_index { get; set; }

    [StringLength(100)]
    public string pli_name { get; set; } = null!;

    public int pli_level { get; set; }

    public int pli_NLS_id { get; set; }

    [Column(TypeName = "text")]
    public string? pli_icon { get; set; }

    public bool pli_pending_download { get; set; }
}
