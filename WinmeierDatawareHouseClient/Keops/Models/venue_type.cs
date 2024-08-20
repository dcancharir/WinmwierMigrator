using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class venue_type
{
    [Key]
    public int vet_venues_types_id { get; set; }

    [StringLength(50)]
    public string vet_name { get; set; } = null!;

    [StringLength(250)]
    public string? vet_description { get; set; }
}
