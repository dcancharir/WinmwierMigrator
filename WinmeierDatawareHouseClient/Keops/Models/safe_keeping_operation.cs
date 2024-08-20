using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class safe_keeping_operation
{
    public long sko_unique_id { get; set; }

    public long sko_operation_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime sko_datetime { get; set; }

    public int sko_type { get; set; }

    public int sko_user_id { get; set; }

    public long sko_cage_sesion { get; set; }

    public long sko_safe_keeping_id { get; set; }

    [Column(TypeName = "money")]
    public decimal sko_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal sko_final_balance { get; set; }
}
