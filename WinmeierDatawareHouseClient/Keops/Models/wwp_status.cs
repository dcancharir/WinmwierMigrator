using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("wwp_status")]
public partial class wwp_status
{
    [Key]
    public int wwp_type { get; set; }

    [Column("wwp_status")]
    public int wwp_status1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wwp_status_changed { get; set; }

    [StringLength(500)]
    public string? wwp_last_address { get; set; }

    public long wwp_sent_bytes { get; set; }

    public long wwp_sent_messages { get; set; }

    public long wwp_received_bytes { get; set; }

    public long wwp_received_messages { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wwp_last_sent_msg { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wwp_last_received_msg { get; set; }
}
