using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("tsmdh_date", "tsmdh_egm_id", "tsmdh_egm_denom", "tsmdh_accounting_denom")]
[Table("terminal_sas_meters_by_denomination_history")]
public partial class terminal_sas_meters_by_denomination_history
{
    [Key]
    public int tsmdh_date { get; set; }

    [Key]
    public int tsmdh_egm_id { get; set; }

    [Key]
    public short tsmdh_egm_denom { get; set; }

    [Key]
    public short tsmdh_accounting_denom { get; set; }

    public short tsmdh_egm_is_multi_denom { get; set; }

    [Column(TypeName = "money")]
    public decimal tsmdh_theo_payout_ratio { get; set; }

    public long tsmdh_d00 { get; set; }

    public long tsmdh_d01 { get; set; }

    public long tsmdh_d02 { get; set; }

    public long tsmdh_d05 { get; set; }

    public long tsmdh_d06 { get; set; }

    public long tsmdh_d07 { get; set; }

    public long tsmdh_d1c { get; set; }

    public long tsmdh_d1d { get; set; }

    public long tsmdh_d1e { get; set; }

    public long tsmdh_d1f { get; set; }

    public long tsmdh_d20 { get; set; }

    public long tsmdh_d21 { get; set; }

    public long tsmdh_d22 { get; set; }

    public long? tsmdh_total_paid { get; set; }

    [Column(TypeName = "numeric(38, 6)")]
    public decimal? tsmdh_theo_paid { get; set; }
}
