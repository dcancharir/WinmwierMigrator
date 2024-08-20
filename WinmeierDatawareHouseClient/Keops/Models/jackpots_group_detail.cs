using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("jackpots_group_detail")]
public partial class jackpots_group_detail
{
    public int jgd_id { get; set; }

    public int jgd_group_id { get; set; }

    public int jgd_jackpot_id { get; set; }

    public int? jgd_jackpot_sub_type { get; set; }

    public int? jgd_order { get; set; }
}
