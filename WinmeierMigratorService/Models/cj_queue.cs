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
}
