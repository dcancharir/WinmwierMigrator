using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("smib_communication_type")]
public partial class smib_communication_type
{
    [Key]
    public int sct_id { get; set; }

    [StringLength(50)]
    public string sct_name { get; set; } = null!;

    [StringLength(300)]
    public string? sct_description { get; set; }

    public bool sct_configurable { get; set; }

    public bool sct_active { get; set; }

    public int? sct_data_type { get; set; }
}
