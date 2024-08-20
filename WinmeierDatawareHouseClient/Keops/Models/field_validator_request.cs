using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class field_validator_request
{
    public long fvr_request_id { get; set; }

    public long fvr_field_id { get; set; }

    public int fvr_validator_type { get; set; }

    public long? fvr_award_flag_id { get; set; }

    [StringLength(500)]
    public string? fvr_param { get; set; }

    public long? fvr_param_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fvr_creation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fvr_expiration { get; set; }
}
