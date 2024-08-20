using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("ms_pending_account_flags_backup")]
public partial class ms_pending_account_flags_backup
{
    public long mpaf_unique_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mpaf_datetime { get; set; }
}
