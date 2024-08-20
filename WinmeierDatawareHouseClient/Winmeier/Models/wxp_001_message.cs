using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Index("wxm_datetime", Name = "IX_wxm_datetime")]
[Index("wxm_terminal_id", "wxm_type", "wxm_status", Name = "IX_wxm_terminal_type_status")]
[Index("wxm_type", "wxm_status", Name = "IX_wxm_type_status")]
public partial class wxp_001_message
{
    [Key]
    public long wxm_id { get; set; }

    public int wxm_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime wxm_datetime { get; set; }

    public int wxm_type { get; set; }

    public int wxm_terminal_id { get; set; }

    [MaxLength(128)]
    public byte[] wxm_data { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime wxm_status_changed { get; set; }
}
