using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_resource
{
    public long lr_id { get; set; }

    public int lr_type { get; set; }

    public int lr_sub_type { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? lr_name { get; set; }

    [Unicode(false)]
    public string lr_data { get; set; } = null!;

    [Unicode(false)]
    public string? lr_options { get; set; }
}
