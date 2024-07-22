using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class VIEW_CARD_BALANCE
{
    [Column("Initial Cash In", TypeName = "money")]
    public decimal Initial_Cash_In { get; set; }

    [Column("Initial Not Redeemable", TypeName = "money")]
    public decimal Initial_Not_Redeemable { get; set; }

    [Column(TypeName = "money")]
    public decimal Balance { get; set; }

    [Column("Not Redeemable", TypeName = "money")]
    public decimal? Not_Redeemable { get; set; }

    [Column("Cash In", TypeName = "money")]
    public decimal? Cash_In { get; set; }

    [Column("Cash Won", TypeName = "money")]
    public decimal? Cash_Won { get; set; }
}
