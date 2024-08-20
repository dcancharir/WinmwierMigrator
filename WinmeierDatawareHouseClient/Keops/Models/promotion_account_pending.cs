using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("promotion_account_pending")]
public partial class promotion_account_pending
{
    public long pap_unique_id { get; set; }

    public long? pap_promo_id { get; set; }

    public long? pap_account_id { get; set; }

    public long? pap_play_session_id { get; set; }

    public bool? pap_approved { get; set; }
}
