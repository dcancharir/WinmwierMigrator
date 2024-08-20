using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class jackpots_viewer
{
    public int jv_jackpot_viewer_Id { get; set; }

    [StringLength(100)]
    public string jv_name { get; set; } = null!;

    public int jv_code { get; set; }

    public bool jv_enabled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? jv_last_update { get; set; }
}
