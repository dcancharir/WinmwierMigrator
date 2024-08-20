using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

public partial class stacker
{
    [Key]
    public long st_stacker_id { get; set; }

    [StringLength(50)]
    public string st_model { get; set; } = null!;

    public int? st_inserted { get; set; }

    [StringLength(200)]
    public string? st_notes { get; set; }

    public int? st_terminal_preassigned { get; set; }

    public int? st_provider_preassigned { get; set; }

    public int st_status { get; set; }
}
