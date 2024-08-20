using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

public partial class wkt_resource
{
    [Key]
    public long res_resource_id { get; set; }

    [StringLength(50)]
    public string res_extension { get; set; } = null!;

    public int res_length { get; set; }

    public byte[]? res_data { get; set; }

    [MaxLength(50)]
    public byte[]? res_hash { get; set; }
}
