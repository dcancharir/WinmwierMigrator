using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class jackpots_award_filters_flag
{
    public int jaf_id { get; set; }

    public int jaf_jackpot_id { get; set; }

    public int jaf_type { get; set; }

    public int jaf_flag_id { get; set; }

    public int jaf_flag_count { get; set; }
}
