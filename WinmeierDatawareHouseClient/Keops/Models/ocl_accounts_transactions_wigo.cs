using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class ocl_accounts_transactions_wigo
{
    public long at_transaction_id { get; set; }

    public long? at_cal_link_id { get; set; }

    public string at_type { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime at_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime at_last_updated { get; set; }

    public string? at_response_message { get; set; }

    public bool? at_response_status { get; set; }

    public long? at_num_movement { get; set; }
}
