using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("promotion_period_of_study_processed")]
public partial class promotion_period_of_study_processed
{
    public long pposp_id { get; set; }

    public long pposp_pos_id { get; set; }

    public long pposp_account_id { get; set; }

    public long? pposp_current_play_session_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pposp_ac_last_activity { get; set; }
}
