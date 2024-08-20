using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("jackpots_settings_awarding")]
public partial class jackpots_settings_awarding
{
    public int jsa_id { get; set; }

    public int jsa_jackpot_id { get; set; }

    public int? jsa_monday_from { get; set; }

    public int? jsa_monday_to { get; set; }

    public int? jsa_tuesday_from { get; set; }

    public int? jsa_tuesday_to { get; set; }

    public int? jsa_wednesday_from { get; set; }

    public int? jsa_wednesday_to { get; set; }

    public int? jsa_thursday_from { get; set; }

    public int? jsa_thursday_to { get; set; }

    public int? jsa_friday_from { get; set; }

    public int? jsa_friday_to { get; set; }

    public int? jsa_saturday_from { get; set; }

    public int? jsa_saturday_to { get; set; }

    public int? jsa_sunday_from { get; set; }

    public int? jsa_sunday_to { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? jsa_last_update { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? jsa_date_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? jsa_date_to { get; set; }
}
