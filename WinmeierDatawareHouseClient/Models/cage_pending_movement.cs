using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class cage_pending_movement
{
    [Key]
    public long cpm_movement_id { get; set; }

    public int cpm_user_id { get; set; }

    public int? cpm_type { get; set; }
}
