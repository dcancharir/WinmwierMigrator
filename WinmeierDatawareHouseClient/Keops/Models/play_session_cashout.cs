using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("play_session_cashout")]
public partial class play_session_cashout
{
    public long psc_cashout_id { get; set; }

    public long psc_play_session_id { get; set; }

    public long? psc_ticket_id { get; set; }

    [Column(TypeName = "money")]
    public decimal psc_billin_gross { get; set; }

    [Column(TypeName = "money")]
    public decimal psc_cashin_tax { get; set; }

    [Column(TypeName = "money")]
    public decimal psc_refund { get; set; }

    [Column(TypeName = "money")]
    public decimal psc_prize { get; set; }

    [Column(TypeName = "money")]
    public decimal psc_cashout { get; set; }

    [Column(TypeName = "money")]
    public decimal psc_federal_tax { get; set; }

    [Column(TypeName = "money")]
    public decimal psc_state_tax { get; set; }

    [Column(TypeName = "money")]
    public decimal psc_municipal_tax { get; set; }

    [Column(TypeName = "money")]
    public decimal psc_rcs_tax { get; set; }

    [Column(TypeName = "money")]
    public decimal psc_theorical_tax { get; set; }

    [Column(TypeName = "money")]
    public decimal psc_total_pay { get; set; }

    public bool psc_flag_recharge_movements { get; set; }
}
