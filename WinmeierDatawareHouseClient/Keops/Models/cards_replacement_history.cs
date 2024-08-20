using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("cards_replacement_history")]
public partial class cards_replacement_history
{
    public long crh_type_replacement_history { get; set; }

    [StringLength(100)]
    public string crh_old_track_data { get; set; } = null!;

    [StringLength(100)]
    public string crh_new_track_data { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime crh_replacement_date { get; set; }

    public int crh_remote_type { get; set; }

    public bool crh_remote_activation { get; set; }

    public bool crh_is_in_use { get; set; }

    public long crh_account_id { get; set; }

    public long crh_operation_id { get; set; }
}
