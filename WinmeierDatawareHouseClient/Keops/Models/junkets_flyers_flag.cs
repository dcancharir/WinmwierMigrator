using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("jff_flyer_id", "jff_flag_id")]
public partial class junkets_flyers_flag
{
    [Key]
    public long jff_flyer_id { get; set; }

    [Key]
    public long jff_flag_id { get; set; }

    public int jff_flag_count { get; set; }
}
