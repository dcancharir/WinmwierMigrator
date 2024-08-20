using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class multisite_request
{
    public long mr_unique_id { get; set; }

    public int mr_priority { get; set; }

    public int mr_request_type { get; set; }

    [StringLength(4000)]
    public string? mr_input_data { get; set; }

    [StringLength(4000)]
    public string? mr_output_data { get; set; }

    public int mr_num_tries { get; set; }

    public int mr_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mr_status_changed { get; set; }
}
