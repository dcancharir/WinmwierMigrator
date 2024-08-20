using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("hierarchy.users")]
public partial class hierarchy_user
{
    public long hu_user_id { get; set; }

    public long? hu_venue_id { get; set; }
}
