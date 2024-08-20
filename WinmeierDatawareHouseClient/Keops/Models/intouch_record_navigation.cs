using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("intouch_record_navigation")]
public partial class intouch_record_navigation
{
    public long irn_id { get; set; }

    public long irn_account_id { get; set; }

    public long irn_terminal_id { get; set; }

    public long irn_current_playsession_id { get; set; }

    public long irn_type_request_id { get; set; }

    [StringLength(50)]
    public string irn_current_action { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime irn_date { get; set; }
}
