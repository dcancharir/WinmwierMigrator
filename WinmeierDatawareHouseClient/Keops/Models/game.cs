using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class game
{
    public int gm_game_id { get; set; }

    [StringLength(100)]
    public string gm_name { get; set; } = null!;

    public byte[]? gm_timestamp { get; set; }
}
