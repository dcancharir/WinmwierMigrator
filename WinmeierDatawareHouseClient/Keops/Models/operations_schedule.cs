using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("operations_schedule")]
public partial class operations_schedule
{
    public long os_unique_id { get; set; }

    public int os_type { get; set; }

    public int? os_day_of_week { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? os_date_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? os_date_to { get; set; }

    public bool os_operations_allowed { get; set; }

    public int os_time1_from { get; set; }

    public int os_time1_to { get; set; }

    public int? os_time2_from { get; set; }

    public int? os_time2_to { get; set; }
}
