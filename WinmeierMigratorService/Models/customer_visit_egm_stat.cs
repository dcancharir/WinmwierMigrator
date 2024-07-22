using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class customer_visit_egm_stat
{
    public long cve_visit_id { get; set; }

    public int cve_credit_type { get; set; }

    [Column(TypeName = "money")]
    public decimal cve_total_in { get; set; }

    [Column(TypeName = "money")]
    public decimal cve_total_out { get; set; }

    [Column(TypeName = "money")]
    public decimal cve_coin_in { get; set; }

    [Column(TypeName = "money")]
    public decimal cve_coin_out { get; set; }

    [Column(TypeName = "money")]
    public decimal cve_jackpot { get; set; }

    [Column(TypeName = "money")]
    public decimal cve_theoretical_coin_out { get; set; }

    public int? cve_playing_time { get; set; }
}
