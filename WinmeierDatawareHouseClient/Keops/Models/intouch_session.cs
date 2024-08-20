using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class intouch_session
{
    [StringLength(50)]
    public string is_machine_name { get; set; } = null!;

    public int is_terminal_id { get; set; }

    [StringLength(40)]
    public string is_terminal_name { get; set; } = null!;

    public int is_resolution_mode { get; set; }

    public int is_subsystem_mode { get; set; }

    public int is_language_id { get; set; }

    [StringLength(400)]
    public string? is_functionalities { get; set; }

    [StringLength(4000)]
    public string? is_redirects { get; set; }

    public long is_account_id { get; set; }
}
