using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class wcp_service
{
    [Key]
    public long wsvr_service_id { get; set; }

    [StringLength(50)]
    public string wsvr_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? wsvr_watchdog { get; set; }

    [InverseProperty("wscq_service")]
    public virtual wcp_services_to_cj_queue? wcp_services_to_cj_queue { get; set; }
}
