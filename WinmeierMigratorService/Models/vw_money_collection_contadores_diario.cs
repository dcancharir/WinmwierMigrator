using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class vw_money_collection_contadores_diario
{
    public long mc_collection_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mc_datetime { get; set; }

    [Column(TypeName = "money")]
    public decimal? mc_collected_bill_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal mc_collected_coin_amount { get; set; }
}
