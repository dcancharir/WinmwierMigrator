using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("object_container")]
public partial class object_container
{
    public int oc_id { get; set; }

    public int oc_subtype { get; set; }

    public string? oc_resource { get; set; }

    public short oc_type_resource { get; set; }
}
