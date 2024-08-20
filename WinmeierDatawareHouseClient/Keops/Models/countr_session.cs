using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class countr_session
{
    public long crs_session_id { get; set; }

    public int crs_countr_id { get; set; }

    public long crs_cashier_session_id { get; set; }

    public int crs_status { get; set; }

    [Column(TypeName = "money")]
    public decimal? crs_initial_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? crs_final_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? crs_collected_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime crs_openning_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? crs_closed_date { get; set; }

    [Column(TypeName = "money")]
    public decimal? crs_withdrawals_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? crs_deposits_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? crs_ticket_amount { get; set; }
}
