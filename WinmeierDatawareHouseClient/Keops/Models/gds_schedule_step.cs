using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Index("gss_schedule_id", "gss_step_index", Name = "PK_gds_schedule_steps", IsUnique = true)]
public partial class gds_schedule_step
{
    public long gss_schedule_id { get; set; }

    public int gss_step_index { get; set; }

    public int gss_target_type { get; set; }

    public long gss_target_id { get; set; }

    public int gss_action_type { get; set; }

    public long? gss_action_data { get; set; }
}
