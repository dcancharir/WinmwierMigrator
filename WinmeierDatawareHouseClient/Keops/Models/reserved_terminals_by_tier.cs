using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("reserved_terminals_by_tier")]
public partial class reserved_terminals_by_tier
{
    [Key]
    public int rtt_terminal_id { get; set; }

    public long rtt_tier_mask { get; set; }
}
