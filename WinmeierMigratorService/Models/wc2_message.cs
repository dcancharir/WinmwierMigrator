using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

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

    [ForeignKey("w2m_session_id")]
    [InverseProperty("wc2_messages")]
    public virtual wc2_session? w2m_session { get; set; }

    [ForeignKey("w2m_terminal_id")]
    [InverseProperty("wc2_messages")]
    public virtual terminal? w2m_terminal { get; set; }
}
