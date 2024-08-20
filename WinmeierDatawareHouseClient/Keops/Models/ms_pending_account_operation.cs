using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class ms_pending_account_operation
{
    [Key]
    public long mpao_operation_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mpao_datetime { get; set; }
}
