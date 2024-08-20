using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class layout_mesh
{
    [Key]
    public long lme_mesh_id { get; set; }

    public int lme_type { get; set; }

    public int? lme_sub_type { get; set; }

    [Unicode(false)]
    public string lme_geometry { get; set; } = null!;
}
