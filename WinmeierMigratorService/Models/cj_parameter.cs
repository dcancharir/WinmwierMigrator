using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class cj_parameter
{
    [StringLength(50)]
    public string? cjp_local_ip_1 { get; set; }

    [StringLength(50)]
    public string? cjp_remote_ip_1 { get; set; }

    [StringLength(50)]
    public string? cjp_vendor_id_1 { get; set; }

    [StringLength(50)]
    public string? cjp_local_ip_2 { get; set; }

    [StringLength(50)]
    public string? cjp_remote_ip_2 { get; set; }

    [StringLength(50)]
    public string? cjp_vendor_id_2 { get; set; }
}
