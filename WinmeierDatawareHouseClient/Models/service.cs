using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("svc_protocol", "svc_machine")]
public partial class service
{
    [Key]
    [StringLength(50)]
    public string svc_protocol { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string svc_machine { get; set; } = null!;

    [StringLength(50)]
    public string svc_ip_address { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime svc_last_access { get; set; }

    [StringLength(50)]
    public string svc_status { get; set; } = null!;

    [StringLength(50)]
    public string? svc_version { get; set; }
}
