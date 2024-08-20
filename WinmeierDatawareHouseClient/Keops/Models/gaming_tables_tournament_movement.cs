using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class gaming_tables_tournament_movement
{
    public long gttm_movement_id { get; set; }

    public long gttm_tournament_id { get; set; }

    public long gttm_account_id { get; set; }

    public int gttm_type { get; set; }

    [Column(TypeName = "money")]
    public decimal gttm_sub_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gttm_add_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gttm_datetime { get; set; }

    public long? gttm_operation_id { get; set; }

    public int? gttm_undo_status { get; set; }
}
