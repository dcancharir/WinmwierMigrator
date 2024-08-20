using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("junkets_commissions_pending")]
public partial class junkets_commissions_pending
{
    public long jcp_id { get; set; }

    public long jcp_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jcp_datetime { get; set; }
}
