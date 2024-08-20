using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("gaming_hall_group_detail")]
public partial class gaming_hall_group_detail
{
    [Key]
    public long ghgd_mc_collection_id { get; set; }

    [Column(TypeName = "xml")]
    public string? ghgd_collected { get; set; }

    [Column(TypeName = "xml")]
    public string? ghgd_deposit { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ghgd_inserted_datetime { get; set; }
}
