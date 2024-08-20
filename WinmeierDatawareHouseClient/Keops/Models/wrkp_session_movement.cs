using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class wrkp_session_movement
{
    public long wsm_session_movement_id { get; set; }

    public long? wsm_session_id { get; set; }

    public int? wsm_io_type { get; set; }

    public int? wsm_type { get; set; }

    public int? wsm_credit_type { get; set; }

    public int? wsm_currency_type { get; set; }

    public int? wsm_quantity { get; set; }

    public long? wsm_denomination { get; set; }

    public int? wsm_value { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wsm_updated_date { get; set; }
}
