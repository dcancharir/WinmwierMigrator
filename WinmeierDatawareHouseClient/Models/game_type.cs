using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("gt_game_type", "gt_language_id")]
[Index("gt_name", "gt_language_id", Name = "IX_gt_name", IsUnique = true)]
public partial class game_type
{
    [Key]
    public int gt_game_type { get; set; }

    [Key]
    public int gt_language_id { get; set; }

    [StringLength(50)]
    public string gt_name { get; set; } = null!;
}
