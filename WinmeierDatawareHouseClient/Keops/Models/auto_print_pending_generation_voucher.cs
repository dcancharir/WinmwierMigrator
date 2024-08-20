using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("appgv_session_id", "appgv_type")]
[Table("auto_print_pending_generation_voucher")]
public partial class auto_print_pending_generation_voucher
{
    [Key]
    public long appgv_session_id { get; set; }

    [Key]
    public int appgv_type { get; set; }
}
