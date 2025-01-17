using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class historical_generated_pattern
{
    [Key]
    public long hgp_id { get; set; }

    public long hgp_al_id { get; set; }

    public long hgp_pattern_id { get; set; }

    [Column(TypeName = "xml")]
    public string hgp_pattern_values { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime hgp_date { get; set; }

    public long hgp_element_id { get; set; }

    public int hgp_alarm_code { get; set; }

    [StringLength(50)]
    public string hgp_alarm_name { get; set; } = null!;

    [StringLength(350)]
    public string? hgp_alarm_description { get; set; }
}
