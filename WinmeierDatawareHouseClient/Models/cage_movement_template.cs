using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Table("cage_movement_template")]
public partial class cage_movement_template
{
    [Key]
    public long cmt_id { get; set; }

    [StringLength(50)]
    public string cmt_name { get; set; } = null!;

    [Column(TypeName = "xml")]
    public string cmt_denominations { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime cmt_creation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cmt_last_used { get; set; }
}
