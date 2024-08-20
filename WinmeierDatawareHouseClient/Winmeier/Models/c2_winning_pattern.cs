using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

public partial class c2_winning_pattern
{
    [Key]
    public int w2p_pattern_id { get; set; }

    public long w2p_min_prize { get; set; }

    public long w2p_max_prize { get; set; }

    public long w2p_position_list { get; set; }
}
