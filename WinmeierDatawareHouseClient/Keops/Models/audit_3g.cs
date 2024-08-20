using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Index("a3gs_execution", "a3gs_vendor_id", "a3gs_machine_number", "a3gs_status_code", Name = "IX_audit_3gs")]
[Index("a3gs_session_id", "a3gs_id", Name = "IX_audit_3gs_session_id_3gs_id")]
public partial class audit_3g
{
    [Column(TypeName = "datetime")]
    public DateTime a3gs_execution { get; set; }

    public long a3gs_id { get; set; }

    [StringLength(50)]
    public string a3gs_procedure { get; set; } = null!;

    [StringLength(24)]
    public string a3gs_account_id { get; set; } = null!;

    [StringLength(16)]
    public string a3gs_vendor_id { get; set; } = null!;

    public int a3gs_machine_number { get; set; }

    [StringLength(30)]
    public string? a3gs_serial_number { get; set; }

    public long? a3gs_session_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? a3gs_balance { get; set; }

    public int a3gs_status_code { get; set; }

    public string? a3gs_input { get; set; }

    public string? a3gs_output { get; set; }
}
