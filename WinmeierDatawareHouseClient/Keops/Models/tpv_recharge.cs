using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class tpv_recharge
{
    public long tr_id { get; set; }

    public long tr_operation_id { get; set; }

    public long tr_account_id { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal tr_amount { get; set; }

    public int tr_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tr_date { get; set; }

    public long? tr_auth_code { get; set; }

    public short? tr_credit_card_last_number { get; set; }
}
