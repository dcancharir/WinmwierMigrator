using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("intouch_terminal_activity")]
public partial class intouch_terminal_activity
{
    [Key]
    public int ita_terminal_id { get; set; }

    [StringLength(50)]
    public string ita_terminal_name { get; set; } = null!;

    [StringLength(30)]
    public string ita_server_name { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ita_traffic { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ita_last_activity { get; set; }
}
