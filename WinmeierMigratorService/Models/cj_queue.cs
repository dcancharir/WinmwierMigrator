using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class cj_queue
{
    [Key]
    public long cq_queue_id { get; set; }

    [StringLength(50)]
    public string? cq_vendor_id { get; set; }

    [StringLength(50)]
    public string? cq_vendor_ip { get; set; }

    [StringLength(256)]
    public string? cq_path { get; set; }

    public int cq_sequence_number { get; set; }

    [InverseProperty("ctx_queue")]
    public virtual ICollection<cj_transaction> cj_transactions { get; set; } = new List<cj_transaction>();

    [InverseProperty("wscq_queue")]
    public virtual ICollection<wcp_services_to_cj_queue> wcp_services_to_cj_queues { get; set; } = new List<wcp_services_to_cj_queue>();
}
