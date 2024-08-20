using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("venue_status")]
public partial class venue_status
{
    [Key]
    public int ves_venue_status_id { get; set; }

    [StringLength(50)]
    public string ves_name { get; set; } = null!;

    [StringLength(250)]
    public string? ves_description { get; set; }
}
