using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("wm_session_id", Name = "IX_wcp_messages_wm_session_id")]
[Index("wm_terminal_id", Name = "IX_wcp_messages_wm_terminal_id")]
public partial class wcp_message
{
    [Key]
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
