using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class csv_control_file
{
    public long ccf_id { get; set; }

    public int ccf_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ccf_journey_date { get; set; }

    public int ccf_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ccf_date { get; set; }

    public int? ccf_object { get; set; }
}
