using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("play_sessions_assignments_history")]
public partial class play_sessions_assignments_history
{
    public long psa_history_id { get; set; }

    public long psa_play_session_id { get; set; }

    public long psa_account_id_origin { get; set; }

    public long psa_account_id_target { get; set; }

    public int psa_terminal_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime psa_datetime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string psa_authorized_by_user { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string psa_machine_name { get; set; } = null!;

    public byte[] psa_timestamp { get; set; } = null!;

    public int psa_play_session_type { get; set; }
}
