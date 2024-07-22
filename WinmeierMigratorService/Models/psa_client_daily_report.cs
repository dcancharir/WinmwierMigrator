using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("psa_client_daily_report")]
public partial class psa_client_daily_report
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime pcdr_date_report { get; set; }

    public int? pcdr_status { get; set; }

    public int? pcdr_num_send { get; set; }

    public int? pcdr_num_registers { get; set; }

    public int? pcdr_num_constancies { get; set; }

    [Column(TypeName = "money")]
    public decimal? pcdr_initial_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal? pcdr_final_balance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pcdr_date_send { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pcdr_date_first_register { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pcdr_date_last_register { get; set; }

    public int? pcdr_register_L007 { get; set; }

    public int? pcdr_register_L006 { get; set; }
}
