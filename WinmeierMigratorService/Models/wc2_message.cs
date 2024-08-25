using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("w2m_session_id", Name = "IX_wc2_messages_w2m_session_id")]
[Index("w2m_terminal_id", Name = "IX_wc2_messages_w2m_terminal_id")]
public partial class wc2_message
{
    [Key]
    public long w2m_message_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime w2m_datetime { get; set; }

    public int? w2m_terminal_id { get; set; }

    public long? w2m_session_id { get; set; }

    public long? w2m_sequence_id { get; set; }

    public bool w2m_towards_to_terminal { get; set; }

    [Column(TypeName = "xml")]
    public string w2m_message { get; set; } = null!;
}
