using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("major_prizes_to_generate")]
public partial class major_prizes_to_generate
{
    [Key]
    public long mpg_operation_id { get; set; }
}
