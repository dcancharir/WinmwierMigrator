using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("hierarchy.venues")]
public partial class hierarchy_venue
{
    [Key]
    public long hv_id { get; set; }

    public Guid hv_tree_id { get; set; }

    public long hv_venue_id { get; set; }
}
