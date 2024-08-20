using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class live_operations_session
{
    [Key]
    public long los_cashier_session_id { get; set; }

    public int los_cashier_terminal_id { get; set; }

    public int los_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? los_insertion_datetime { get; set; }

    public int los_venue_id { get; set; }
}
