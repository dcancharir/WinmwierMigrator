using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("jackpots_settings_happy_hour")]
public partial class jackpots_settings_happy_hour
{
    public int jhh_id { get; set; }

    public int jhh_jackpot_id { get; set; }

    public int jhh_event_type { get; set; }

    [Column(TypeName = "money")]
    public decimal jhh_minimum { get; set; }

    [Column(TypeName = "money")]
    public decimal jhh_maximum { get; set; }

    public int? jhh_time_before { get; set; }

    public int? jhh_awards_before { get; set; }

    public int? jhh_amount_distribution_before { get; set; }

    public int? jhh_time_after { get; set; }

    public int? jhh_awards_after { get; set; }

    public int? jhh_amount_distribution_after { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? jhh_last_update { get; set; }
}
