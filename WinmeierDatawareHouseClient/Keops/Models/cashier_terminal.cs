using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class cashier_terminal
{
    public int ct_cashier_id { get; set; }

    [StringLength(100)]
    public string ct_name { get; set; } = null!;

    public int? ct_terminal_id { get; set; }

    public bool ct_hide_osk { get; set; }

    public long? ct_sequence_id { get; set; }

    public long? ct_virtual_account_id { get; set; }

    public int? ct_gaming_table_id { get; set; }

    public int? CT_ID_CARD_SCANNER_MODEL { get; set; }

    [StringLength(100)]
    public string? CT_ID_CARD_SCANNER_CONFIG { get; set; }

    public int? CT_COUNTR_ID { get; set; }

    public bool ct_pinpad_enabled { get; set; }

    [StringLength(80)]
    public string? ct_related_device_ip { get; set; }

    public int ct_related_device_draw { get; set; }

    public int? ct_bank_id { get; set; }

    [StringLength(40)]
    public string? ct_floor_id { get; set; }

    public int? ct_position { get; set; }

    public string? ct_card_printer_name { get; set; }

    public int? ct_permissions_mode { get; set; }

    public int? ct_device_draw_terminal_id { get; set; }

    public string? ct_receipt_printer_name { get; set; }
}
