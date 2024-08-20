using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class card_item
{
    public long ci_id { get; set; }

    public long? ci_card_template_id { get; set; }

    public int? ci_card_type { get; set; }

    public long? ci_item_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ci_creation_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ci_last_update_date { get; set; }
}
