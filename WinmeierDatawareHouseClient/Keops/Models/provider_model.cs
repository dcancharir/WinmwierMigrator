using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Index("pm_provider_id", "pm_model", Name = "IDX_provider_id_model", IsUnique = true)]
public partial class provider_model
{
    [Key]
    public Guid pm_model_id { get; set; }

    public int pm_provider_id { get; set; }

    [StringLength(50)]
    public string pm_provider_name { get; set; } = null!;

    [StringLength(50)]
    public string pm_model { get; set; } = null!;

    public long? pm_ms_sequence_id { get; set; }
}
