using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class junkets_commissions_movement
{
    public long jcm_id { get; set; }

    public long jcm_account_id { get; set; }

    public long jcm_flyer_id { get; set; }

    public long jcm_operation_id { get; set; }

    public int jcm_type { get; set; }

    public int jcm_status { get; set; }

    [Column(TypeName = "money")]
    public decimal jcm_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jcm_creation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? jcm_paid { get; set; }
}
