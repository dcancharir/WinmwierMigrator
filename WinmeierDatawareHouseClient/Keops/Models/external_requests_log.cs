using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("external_requests_log")]
public partial class external_requests_log
{
    public long erl_id { get; set; }

    public string? erl_request { get; set; }

    public string? erl_response { get; set; }

    public int erl_elapsed_time { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime erl_datetime { get; set; }
}
