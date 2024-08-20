using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class lcd_nls_resource
{
    [Key]
    public int nres_id { get; set; }

    [StringLength(50)]
    public string nres_name { get; set; } = null!;

    public long nres_resource_id { get; set; }

    public int nres_resource_length { get; set; }
}
