using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class Temp_account_point
{
    [Key]
    public long AccountId { get; set; }

    [Column(TypeName = "money")]
    public decimal? BalancePuntos { get; set; }
}
