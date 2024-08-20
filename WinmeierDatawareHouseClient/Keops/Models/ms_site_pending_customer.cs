using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class ms_site_pending_customer
{
    [Key]
    public long spc_customer_id { get; set; }

    public Guid? spc_guid { get; set; }
}
