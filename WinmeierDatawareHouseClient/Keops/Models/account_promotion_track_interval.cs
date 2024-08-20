using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("apti_day", "apti_hhmm", "apti_promo_id", "apti_account_id")]
public partial class account_promotion_track_interval
{
    [Key]
    public DateOnly apti_day { get; set; }

    [Key]
    public short apti_hhmm { get; set; }

    [Key]
    public long apti_promo_id { get; set; }

    [Key]
    public long apti_account_id { get; set; }
}
