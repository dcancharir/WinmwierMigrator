using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("rep_date", "rep_type")]
public partial class report
{
    [Key]
    public int rep_type { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime rep_date { get; set; }

    [Column(TypeName = "xml")]
    public string rep_data { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime rep_created { get; set; }
}
