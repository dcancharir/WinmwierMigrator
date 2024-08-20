using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class wkt_resource
{
    public long res_resource_id { get; set; }

    [StringLength(100)]
    public string res_extension { get; set; } = null!;

    public int res_length { get; set; }

    [MaxLength(1)]
    public byte[]? res_data { get; set; }

    [MaxLength(1)]
    public byte[]? res_hash { get; set; }
}
