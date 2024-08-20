using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class c2_jackpot_counter
{
    [Key]
    public int c2jc_index { get; set; }

    [Column(TypeName = "numeric(20, 8)")]
    public decimal c2jc_accumulated { get; set; }

    [Column(TypeName = "numeric(20, 8)")]
    public decimal c2jc_to_compensate { get; set; }
}
