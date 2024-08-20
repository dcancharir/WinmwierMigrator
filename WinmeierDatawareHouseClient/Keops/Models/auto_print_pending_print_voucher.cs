using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("apppv_voucher_id", "apppv_type")]
[Table("auto_print_pending_print_voucher")]
public partial class auto_print_pending_print_voucher
{
    [Key]
    public long apppv_voucher_id { get; set; }

    [Key]
    public int apppv_type { get; set; }
}
