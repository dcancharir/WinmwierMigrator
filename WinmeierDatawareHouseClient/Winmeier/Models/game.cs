using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Index("gm_name", Name = "IX_games", IsUnique = true)]
public partial class game
{
    [Key]
    public int gm_game_id { get; set; }

    [StringLength(50)]
    public string gm_name { get; set; } = null!;

    public byte[]? gm_timestamp { get; set; }
}
