using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("promotion_account_restriction")]
public partial class promotion_account_restriction
{
    public long acr_unique_id { get; set; }

    public long acr_promotion_id { get; set; }

    public long acr_account_id { get; set; }
}
