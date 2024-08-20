using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class group_element
{
    public long ge_id { get; set; }

    public int ge_element_type { get; set; }

    public long ge_element_id { get; set; }

    public long ge_group_id { get; set; }

    public string ge_query { get; set; } = null!;
}
