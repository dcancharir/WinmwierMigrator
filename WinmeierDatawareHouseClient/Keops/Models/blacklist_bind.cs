using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class blacklist_bind
{
    [Key]
    public int bb_id { get; set; }

    [StringLength(50)]
    public string? bb_name { get; set; }

    public bool bb_status { get; set; }
}
