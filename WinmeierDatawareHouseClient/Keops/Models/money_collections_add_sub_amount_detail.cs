using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("mcasad_id", "mcasad_face_value")]
[Index("mcasad_id", "mcasad_face_value", "mcasad_cage_currency_type", Name = "IX_id_facevalue_currencytype")]
public partial class money_collections_add_sub_amount_detail
{
    [Key]
    public long mcasad_id { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal mcasad_face_value { get; set; }

    public int mcasad_cage_currency_type { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcasad_quantity { get; set; }
}
