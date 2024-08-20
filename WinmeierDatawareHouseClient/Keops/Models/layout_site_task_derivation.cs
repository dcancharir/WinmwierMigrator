using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_site_task_derivation
{
    public long lstd_task_id { get; set; }

    public int lstd_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lstd_rejected_date { get; set; }
}
