using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("JACKPOT_TAX_TEMPLATE_BKP_2022_03")]
public partial class JACKPOT_TAX_TEMPLATE_BKP_2022_03
{
    public long jtt_id { get; set; }

    public byte[]? jtt_template { get; set; }

    [StringLength(50)]
    public string? jtt_description { get; set; }
}
