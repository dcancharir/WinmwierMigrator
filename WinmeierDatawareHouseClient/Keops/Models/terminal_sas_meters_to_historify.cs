using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("terminal_sas_meters_to_historify")]
public partial class terminal_sas_meters_to_historify
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime tsmmh_date_to_process { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmmh_process_date_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmmh_process_date_end { get; set; }
}
