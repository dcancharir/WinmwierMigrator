using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("ms_site_pending_merge_customers_balance")]
public partial class ms_site_pending_merge_customers_balance
{
    [Key]
    public long spmcb_customer_target_id { get; set; }

    public Guid? spmcb_guid { get; set; }
}
