using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class ms_site_pending_customer_record_detail
{
    [Key]
    public long spcrd_curd_detail_id { get; set; }

    public Guid? spcrd_guid { get; set; }
}
