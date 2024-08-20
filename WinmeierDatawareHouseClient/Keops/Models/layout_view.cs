using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class layout_view
{
    [Key]
    public int lv_id { get; set; }

    [StringLength(500)]
    public string lv_desc { get; set; } = null!;

    public string lv_value { get; set; } = null!;

    public int lv_type { get; set; }
}
