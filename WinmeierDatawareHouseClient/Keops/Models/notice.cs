using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Index("ng_group_id", Name = "IX_notices_ng_group_id")]
public partial class notice
{
    [Key]
    public int no_notice_code { get; set; }

    public int ng_group_id { get; set; }

    [StringLength(250)]
    public string no_description { get; set; } = null!;

    public bool no_status { get; set; }
}
