using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class blocked_table
{
    [Key]
    [StringLength(400)]
    public string bt_table_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? bt_blocked_datetime { get; set; }
}
