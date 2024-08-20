using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class tito_task
{
    public long tt_task_unique_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tt_task_inserted { get; set; }

    public int tt_task_type { get; set; }

    public long tt_ticket_id { get; set; }
}
