using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("mobibank_request_status_expired_reason")]
public partial class mobibank_request_status_expired_reason
{
    public int mbrser_id { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? mbrser_name { get; set; }
}
