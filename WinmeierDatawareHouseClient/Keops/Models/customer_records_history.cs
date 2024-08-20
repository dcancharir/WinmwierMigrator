using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("customer_records_history")]
public partial class customer_records_history
{
    public long curh_record_history_id { get; set; }

    public long curh_record_id { get; set; }

    public long curh_customer_id { get; set; }

    public bool curh_deleted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime curh_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? curh_expiration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime curh_logdate { get; set; }
}
