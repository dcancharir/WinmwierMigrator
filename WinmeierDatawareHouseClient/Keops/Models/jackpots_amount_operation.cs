using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class jackpots_amount_operation
{
    public long jao_id { get; set; }

    public int jao_jackpot_id { get; set; }

    public int jao_jackpot_type { get; set; }

    public int jao_type { get; set; }

    public int jao_status { get; set; }

    [Column(TypeName = "money")]
    public decimal? jao_amount { get; set; }

    [StringLength(100)]
    public string? jao_user_name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jao_creation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jao_last_update { get; set; }
}
