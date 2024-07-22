using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Keyless]
public partial class wxp_parameter
{
    [Column(TypeName = "datetime")]
    public DateTime? wxp_last_execution { get; set; }
}
