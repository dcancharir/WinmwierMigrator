using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("venue_operator")]
public partial class venue_operator
{
    public int vo_id { get; set; }

    [StringLength(12)]
    public string vo_inscription { get; set; } = null!;

    [StringLength(18)]
    public string vo_nif { get; set; } = null!;

    [StringLength(250)]
    public string vo_name { get; set; } = null!;

    [StringLength(250)]
    public string vo_address { get; set; } = null!;

    [StringLength(250)]
    public string vo_department { get; set; } = null!;

    [StringLength(10)]
    public string vo_cp { get; set; } = null!;
}
