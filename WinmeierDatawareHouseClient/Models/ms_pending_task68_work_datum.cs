using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class ms_pending_task68_work_datum
{
    [Key]
    public long mptwd_operation_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mptwd_datetime { get; set; }
}
