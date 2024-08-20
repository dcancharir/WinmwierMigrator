using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("cashier_session_transfer")]
public partial class cashier_session_transfer
{
    public long cst_transfer_id { get; set; }

    public long cst_session_source_id { get; set; }

    public long cst_session_target_id { get; set; }

    public int cst_status { get; set; }

    public long cst_operation_source_id { get; set; }

    public long? cst_operation_target_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cst_date { get; set; }

    [Column(TypeName = "xml")]
    public string cst_denomination_detail { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? cst_amount { get; set; }
}
