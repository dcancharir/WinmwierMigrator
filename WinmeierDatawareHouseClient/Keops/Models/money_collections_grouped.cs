using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("money_collections_grouped")]
public partial class money_collections_grouped
{
    [Key]
    public long mcg_money_collection_id { get; set; }

    public int mcg_grouped { get; set; }
}
