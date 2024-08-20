using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("hierarchy.group_elements")]
[Index("hge_group_id", Name = "IX_hierarchy.group_elements_hge_group_id")]
[Index("hge_venue_id", Name = "IX_hierarchy.group_elements_hge_venue_id")]
public partial class hierarchy_group_element
{
    [Key]
    public int hge_id { get; set; }

    public long hge_group_id { get; set; }

    public int? hge_venue_id { get; set; }

    public int? hge_parent_level { get; set; }

    public bool hge_enabled { get; set; }

    public int hge_element_id { get; set; }

    public int? hge_type { get; set; }
}
