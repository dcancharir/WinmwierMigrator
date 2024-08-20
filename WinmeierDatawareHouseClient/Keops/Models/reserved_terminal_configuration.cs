using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("reserved_terminal_configuration")]
public partial class reserved_terminal_configuration
{
    [Key]
    public int rtc_holder_level { get; set; }

    public int rtc_minutes { get; set; }

    [Column(TypeName = "xml")]
    public string? rtc_terminal_list { get; set; }

    [Column(TypeName = "xml")]
    public string? rtc_selected_terminals { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime rtc_create_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime rtc_update_date { get; set; }

    public int rtc_status { get; set; }

    public bool? rtc_enabled { get; set; }

    [Column(TypeName = "money")]
    public decimal? rtc_coin_in { get; set; }
}
