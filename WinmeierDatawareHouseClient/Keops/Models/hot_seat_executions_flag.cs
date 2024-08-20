using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class hot_seat_executions_flag
{
    public long hsef_id { get; set; }

    public long hsef_hot_seat_execution_id { get; set; }

    public int hsef_type { get; set; }

    public long hsef_flag_id { get; set; }

    public int hsef_flag_count { get; set; }
}
