using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("Install_components_info")]
public partial class Install_components_info
{
    public int Id { get; set; }

    public int Install_Components_Id { get; set; }

    [Column("Install_components_info")]
    public string Install_components_info1 { get; set; } = null!;
}
