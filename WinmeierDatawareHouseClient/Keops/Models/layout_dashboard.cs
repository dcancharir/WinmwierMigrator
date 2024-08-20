using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class layout_dashboard
{
    [Key]
    public int ld_role_id { get; set; }

    [Unicode(false)]
    public string? ld_dashboard { get; set; }
}
