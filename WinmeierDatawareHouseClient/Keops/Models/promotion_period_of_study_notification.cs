using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class promotion_period_of_study_notification
{
    public long ppos_id { get; set; }

    public long ppos_promotion_id { get; set; }

    public long ppos_account_id { get; set; }
}
