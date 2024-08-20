using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class jackpots_amount_terminal
{
    [Key]
    public int jat_terminal_id { get; set; }

    [Column(TypeName = "money")]
    public decimal jat_amount { get; set; }
}
