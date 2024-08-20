using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("mobibank_request_status")]
public partial class mobibank_request_status
{
    public int mbrs_id { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? mbrs_name { get; set; }
}
