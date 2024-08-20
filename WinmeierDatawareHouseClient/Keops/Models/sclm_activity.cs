using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("sclm_activity")]
public partial class sclm_activity
{
    public long sclm_id { get; set; }

    public int sclm_filetype { get; set; }

    public int sclm_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime sclm_generationdate { get; set; }

    public DateOnly sclm_reportingdate { get; set; }

    public int sclm_status { get; set; }

    [Unicode(false)]
    public string? sclm_status_detail { get; set; }

    [Unicode(false)]
    public string? sclm_content { get; set; }

    public int sclm_generationtype { get; set; }

    [Unicode(false)]
    public string? sclm_response { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? sclm_response_code { get; set; }

    [Unicode(false)]
    public string? sclm_response_auth { get; set; }

    [Unicode(false)]
    public string? sclm_response_encrypt { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? sclm_response_radicado { get; set; }
}
