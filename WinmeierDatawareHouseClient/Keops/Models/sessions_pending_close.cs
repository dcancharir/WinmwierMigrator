using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("sessions_pending_close")]
public partial class sessions_pending_close
{
    public long spc_id { get; set; }

    public int spc_cashier_session_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime spc_date_to_close { get; set; }

    public int spc_status { get; set; }

    public int? spc_retries { get; set; }
}
