using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class notice_group
{
    [Key]
    public int ng_group_id { get; set; }

    [StringLength(250)]
    public string ng_name { get; set; } = null!;

    public int ng_order { get; set; }

    public bool ng_status { get; set; }
}
