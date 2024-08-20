using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_object
{
    public long lo_id { get; set; }

    public long? lo_external_id { get; set; }

    public int lo_type { get; set; }

    public long? lo_parent_id { get; set; }

    public int? lo_mesh_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime lo_creation_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lo_update_date { get; set; }

    public int lo_status { get; set; }
}
