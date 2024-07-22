using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("ct_name", Name = "IX_cashier_terminals", IsUnique = true)]
[Index("ct_terminal_id", Name = "IX_ct_terminal_id")]
public partial class cashier_terminal
{
    [Key]
    public int ct_cashier_id { get; set; }

    [StringLength(50)]
    public string ct_name { get; set; } = null!;

    public int? ct_terminal_id { get; set; }

    public bool ct_hide_osk { get; set; }

    public long? ct_sequence_id { get; set; }

    public long? ct_virtual_account_id { get; set; }

    public int? ct_gaming_table_id { get; set; }

    public int? CT_ID_CARD_SCANNER_MODEL { get; set; }

    [StringLength(50)]
    public string? CT_ID_CARD_SCANNER_CONFIG { get; set; }

    public int? CT_COUNTR_ID { get; set; }

    public bool ct_pinpad_enabled { get; set; }
}
