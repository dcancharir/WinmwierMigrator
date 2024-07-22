using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("gtcs_gaming_table_id", "gtcs_chips_set_id")]
public partial class gaming_table_chips_set
{
    [Key]
    public long gtcs_gaming_table_id { get; set; }

    [Key]
    public long gtcs_chips_set_id { get; set; }
}
