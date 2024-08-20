using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class authorization_limit
{
    [Key]
    public long al_id { get; set; }

    public int al_profile_id { get; set; }

    [Column(TypeName = "money")]
    public decimal al_limit { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime al_created { get; set; }

    public short al_type { get; set; }
}
