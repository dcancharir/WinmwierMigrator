using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("mcasa_id", "mcasa_money_collection_id", "mcasa_cashier_movement_id")]
[Table("money_collections_add_sub_amount")]
[Index("mcasa_money_collection_id", "mcasa_type", Name = "IX_collection_type")]
public partial class money_collections_add_sub_amount
{
    [Key]
    public long mcasa_id { get; set; }

    [Key]
    public long mcasa_money_collection_id { get; set; }

    [Key]
    public long mcasa_cashier_movement_id { get; set; }

    public int mcasa_type { get; set; }

    [Column(TypeName = "money")]
    public decimal mcasa_amount { get; set; }
}
