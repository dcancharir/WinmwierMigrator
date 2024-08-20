using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("players_online")]
[Index("po_site_id", "po_terminal_id", Name = "PK_players_online", IsUnique = true)]
public partial class players_online
{
    [Key]
    public long po_terminal_id { get; set; }

    [StringLength(40)]
    public string po_terminal_base_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime po_start_datetime { get; set; }

    public int po_site_id { get; set; }

    [StringLength(200)]
    public string po_full_name { get; set; } = null!;

    public long po_user_id { get; set; }
}
