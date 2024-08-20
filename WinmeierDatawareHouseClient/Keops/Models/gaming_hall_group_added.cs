using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("gaming_hall_group_added")]
public partial class gaming_hall_group_added
{
    [Key]
    public long ghga_collection_group_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? ghga_cash_added_amount { get; set; }
}
