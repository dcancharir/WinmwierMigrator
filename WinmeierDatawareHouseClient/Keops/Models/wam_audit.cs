using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("wam_audit")]
public partial class wam_audit
{
    public long wau_id { get; set; }

    public string wau_transaction_id { get; set; } = null!;

    public long wau_operation_id { get; set; }

    public long wau_account_id { get; set; }

    public int wau_action { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime wau_datetime { get; set; }
}
