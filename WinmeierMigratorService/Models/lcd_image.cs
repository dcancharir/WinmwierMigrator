using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class lcd_image
{
    [Key]
    public int cim_image_id { get; set; }

    [StringLength(50)]
    public string cim_name { get; set; } = null!;

    public long cim_resource_id { get; set; }

    public int cim_expected_w { get; set; }

    public int cim_expected_h { get; set; }

    public int cim_resource_length { get; set; }

    [StringLength(50)]
    public string cim_resource_name { get; set; } = null!;
}
