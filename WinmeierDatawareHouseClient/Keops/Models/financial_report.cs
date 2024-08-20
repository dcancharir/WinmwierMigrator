using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("financial_report")]
public partial class financial_report
{
    public int id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fr_date { get; set; }

    [StringLength(100)]
    public string? rfiscal { get; set; }

    public long? M0 { get; set; }

    public long? M1 { get; set; }

    public long? M2 { get; set; }

    public long? M3 { get; set; }

    public long? M4 { get; set; }

    public long? M5 { get; set; }

    public long? M10 { get; set; }

    public long? BILL_IN { get; set; }

    public long? BILL_COLLECTED { get; set; }

    public long? M36 { get; set; }

    public long? M46 { get; set; }

    public long? M50 { get; set; }

    public long? M88 { get; set; }

    public long? M128 { get; set; }

    public long? M130 { get; set; }

    public long? M132 { get; set; }

    public long? M134 { get; set; }

    public long? M136 { get; set; }

    public long? M160 { get; set; }

    public long? M162 { get; set; }

    public long? M164 { get; set; }

    public long? M184 { get; set; }

    public long? M186 { get; set; }

    public long? M188 { get; set; }

    public long? M4096 { get; set; }

    public long? AFT_IN { get; set; }

    public long? AFT_OUT { get; set; }

    public long? JACKPOT_PROGRESSIVE_CANCEL_CREDIT { get; set; }

    public long? JACKPOT { get; set; }

    public long? PROGRESSIVE { get; set; }

    public long? CANCEL_CREDIT { get; set; }

    public long? TICKET_IN { get; set; }

    public long? TICKET_COLLECTED { get; set; }

    public long? TICKET_COLLECTED_PROMO { get; set; }

    public long? TICKET_OUT { get; set; }

    public long? TOTAL_DROP { get; set; }

    public long? CASH_OUT_JACKPOT_PROGRESSIVE_CANCEL_CREDIT { get; set; }

    public long? WIN_METER { get; set; }

    public long? NET_WIN { get; set; }

    public double? NET_HOLD { get; set; }

    public long? M11 { get; set; }

    public long? M29 { get; set; }

    public long? M138 { get; set; }
}
