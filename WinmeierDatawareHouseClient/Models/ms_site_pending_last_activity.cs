using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Table("ms_site_pending_last_activity")]
public partial class ms_site_pending_last_activity
{
    [Key]
    public long laa_account_id { get; set; }

    public byte[] laa_timestamp { get; set; } = null!;
}
