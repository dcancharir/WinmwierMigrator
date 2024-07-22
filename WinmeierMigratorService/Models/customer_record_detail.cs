using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class customer_record_detail
{
    [Key]
    public long curd_detail_id { get; set; }

    public long curd_record_id { get; set; }

    public bool curd_deleted { get; set; }

    public int curd_type { get; set; }

    public string? curd_data { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime curd_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? curd_expiration { get; set; }

    public byte[]? curd_image { get; set; }
}
