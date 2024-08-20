using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("mcd_collection_id", "mcd_face_value", "mcd_cage_currency_type")]
public partial class money_collection_detail
{
    [Key]
    public long mcd_collection_id { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal mcd_face_value { get; set; }

    [Key]
    public int mcd_cage_currency_type { get; set; }

    [Column(TypeName = "money")]
    public decimal mcd_num_expected { get; set; }

    [Column(TypeName = "money")]
    public decimal mcd_num_collected { get; set; }
}
