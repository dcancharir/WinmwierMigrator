using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Table("fbm_log")]
[Index("fl_creation", Name = "IX_creation_datetime", AllDescending = true)]
[Index("fl_status", "fl_type", Name = "IX_status_type")]
public partial class fbm_log
{
    [Key]
    public long fl_id { get; set; }

    public int fl_status { get; set; }

    public int fl_type { get; set; }

    [Column(TypeName = "xml")]
    public string? fl_request { get; set; }

    [Column(TypeName = "xml")]
    public string? fl_response { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fl_creation { get; set; }

    [StringLength(50)]
    public string fl_creation_user { get; set; } = null!;
}
