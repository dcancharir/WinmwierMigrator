using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class sas_meters_group
{
    [Key]
    public int smg_group_id { get; set; }

    [StringLength(50)]
    public string smg_name { get; set; } = null!;

    [StringLength(200)]
    public string? smg_description { get; set; }

    public bool smg_required { get; set; }
}
