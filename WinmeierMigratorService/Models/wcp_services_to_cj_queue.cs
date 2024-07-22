using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class wcp_services_to_cj_queue
{
    [Key]
    public long wscq_service_id { get; set; }

    public long wscq_queue_id { get; set; }

    [ForeignKey("wscq_queue_id")]
    [InverseProperty("wcp_services_to_cj_queues")]
    public virtual cj_queue wscq_queue { get; set; } = null!;

    [ForeignKey("wscq_service_id")]
    [InverseProperty("wcp_services_to_cj_queue")]
    public virtual wcp_service wscq_service { get; set; } = null!;
}
