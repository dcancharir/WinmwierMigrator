using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class cage_session
{
    public long cgs_cage_session_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cgs_open_datetime { get; set; }

    public int cgs_open_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cgs_close_datetime { get; set; }

    public int? cgs_close_user_id { get; set; }

    [StringLength(100)]
    public string? cgs_session_name { get; set; }

    [Unicode(false)]
    public string? cgs_cage_stock { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cgs_working_day { get; set; }

    public int? cgs_vault_id { get; set; }
}
