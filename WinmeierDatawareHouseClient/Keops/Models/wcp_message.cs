using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class wcp_message
{
    public long wm_message_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime wm_datetime { get; set; }

    public int? wm_terminal_id { get; set; }

    public long? wm_session_id { get; set; }

    public long? wm_sequence_id { get; set; }

    public bool wm_towards_to_terminal { get; set; }

    [Column(TypeName = "xml")]
    public string wm_message { get; set; } = null!;
}
