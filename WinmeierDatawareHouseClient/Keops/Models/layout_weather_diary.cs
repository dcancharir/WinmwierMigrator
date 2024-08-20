using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("layout_weather_diary")]
public partial class layout_weather_diary
{
    [Key]
    public int lwd_date { get; set; }

    public int lwd_weather_code { get; set; }

    [Column(TypeName = "xml")]
    public string lwd_response { get; set; } = null!;
}
