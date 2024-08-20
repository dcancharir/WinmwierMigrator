using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("vg_item_id", "vg_element_id", "vg_element_type")]
public partial class venue_group
{
    [Key]
    public long vg_item_id { get; set; }

    [Key]
    public long vg_element_id { get; set; }

    [Key]
    public int vg_element_type { get; set; }
}
