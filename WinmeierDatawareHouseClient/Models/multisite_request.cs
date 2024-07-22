using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Index("mr_status", Name = "IX_mr_status")]
[Index("mr_status_changed", "mr_status", Name = "IX_mr_status_changed_mr_status")]
public partial class multisite_request
{
    [Key]
    public long mr_unique_id { get; set; }

    public int mr_priority { get; set; }

    public int mr_request_type { get; set; }

    [StringLength(2000)]
    public string? mr_input_data { get; set; }

    [StringLength(2000)]
    public string? mr_output_data { get; set; }

    public int mr_num_tries { get; set; }

    public int mr_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mr_status_changed { get; set; }
}
