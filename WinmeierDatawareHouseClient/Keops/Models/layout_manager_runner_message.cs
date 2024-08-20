using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_manager_runner_message
{
    public long lmrm_id { get; set; }

    public long lmrm_manager_id { get; set; }

    public long lmrm_runner_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime lmrm_date { get; set; }

    [Column(TypeName = "text")]
    public string lmrm_message { get; set; } = null!;

    public int lmrm_source { get; set; }

    public int lmrm_status { get; set; }
}
