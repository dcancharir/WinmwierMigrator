using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("mwm_path_id", "mwm_terminal_id", "mwm_weights_id")]
public partial class machine_weights_machine
{
    [Key]
    [StringLength(50)]
    public string mwm_path_id { get; set; } = null!;

    [Key]
    public long mwm_terminal_id { get; set; }

    [Key]
    public int mwm_weights_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? mwm_weight { get; set; }
}
