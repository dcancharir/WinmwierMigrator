using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("ss_id", "ss_site_id")]
public partial class site_service
{
    [Key]
    public int ss_id { get; set; }

    [Key]
    public int ss_site_id { get; set; }

    public int ss_site_services_related { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string ss_ip { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string ss_port { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ss_last_time_used { get; set; }
}
