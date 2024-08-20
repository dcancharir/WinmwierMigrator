using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("terminal_communication_type")]
public partial class terminal_communication_type
{
    public int tct_id { get; set; }

    public int tct_terminal_type { get; set; }

    public int tct_communication_type { get; set; }

    public bool tct_active { get; set; }

    public bool tct_default { get; set; }
}
