using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("intouch_web_log")]
public partial class intouch_web_log
{
    public long iwl_id { get; set; }

    [StringLength(50)]
    public string iwl_server_name { get; set; } = null!;

    public long iwl_terminal_id { get; set; }

    [StringLength(50)]
    public string iwl_terminal_name { get; set; } = null!;

    public int iwl_type_message_id { get; set; }

    [Column(TypeName = "text")]
    public string iwl_message { get; set; } = null!;

    public bool iwl_is_exception { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime iwl_date { get; set; }

    public int? iwl_account_id { get; set; }

    [StringLength(50)]
    public string? iwl_trackdata { get; set; }

    public long? iwl_playsession_id { get; set; }
}
