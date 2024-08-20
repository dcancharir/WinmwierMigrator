using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("tlmt_terminal_id", "tlmt_msg_type", "tlmt_key")]
[Table("terminal_last_msg_type")]
public partial class terminal_last_msg_type
{
    [Key]
    public int tlmt_terminal_id { get; set; }

    [Key]
    [StringLength(50)]
    public string tlmt_msg_type { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string tlmt_key { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime tlmt_last_msg_date { get; set; }

    public string tlmt_data { get; set; } = null!;
}
