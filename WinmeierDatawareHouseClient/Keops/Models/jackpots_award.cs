using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("jackpots_award")]
public partial class jackpots_award
{
    public long ja_id { get; set; }

    public int ja_jackpot_id { get; set; }

    public int ja_type { get; set; }

    [Column(TypeName = "numeric(20, 8)")]
    public decimal ja_amount { get; set; }

    public long ja_related_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ja_creation { get; set; }
}
