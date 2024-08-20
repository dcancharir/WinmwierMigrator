using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("draw_account_restriction")]
public partial class draw_account_restriction
{
    public long dacr_unique_id { get; set; }

    public long dacr_draw_id { get; set; }

    public long dacr_account_id { get; set; }
}
