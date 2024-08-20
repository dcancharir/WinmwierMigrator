using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class ms_pending_account_movement
{
    [Key]
    public long mpam_movement_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mpam_datetime { get; set; }
}
