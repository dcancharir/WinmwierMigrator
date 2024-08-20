using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("countr_log")]
public partial class countr_log
{
    public long crl_id { get; set; }

    public int crl_code { get; set; }

    public string? crl_request { get; set; }

    public string? crl_response { get; set; }

    public int crl_elapsed_time { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime crl_datetime { get; set; }
}
