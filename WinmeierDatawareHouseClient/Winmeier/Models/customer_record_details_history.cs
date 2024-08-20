using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Table("customer_record_details_history")]
public partial class customer_record_details_history
{
    [Key]
    public long curdh_detail_history_id { get; set; }

    public long curdh_record_id { get; set; }

    public bool curdh_deleted { get; set; }

    public int curdh_type { get; set; }

    public string? curdh_data { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime curdh_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? curdh_expiration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime curdh_logdate { get; set; }

    public byte[]? curdh_image { get; set; }
}
