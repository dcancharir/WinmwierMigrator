using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("smib_configuration")]
public partial class smib_configuration
{
    public long sc_configuration_id { get; set; }

    public int sc_comm_type { get; set; }

    [StringLength(100)]
    public string sc_name { get; set; } = null!;

    [StringLength(400)]
    public string? sc_description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sc_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sc_modified { get; set; }
}
