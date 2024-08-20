using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("tv_site_id", "tv_gaming_day", "tv_customer_id")]
public partial class today_visit
{
    [Key]
    public int tv_site_id { get; set; }

    [Key]
    public int tv_gaming_day { get; set; }

    [Key]
    public long tv_customer_id { get; set; }
}
