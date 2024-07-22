using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class wkt_image
{
    [Key]
    public int cim_image_id { get; set; }

    [StringLength(50)]
    public string cim_name { get; set; } = null!;

    public long cim_resource_id { get; set; }

    public int cim_expected_w { get; set; }

    public int cim_expected_h { get; set; }
}
