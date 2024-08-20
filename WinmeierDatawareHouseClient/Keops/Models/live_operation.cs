using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class live_operation
{
    [Key]
    public Guid lo_operation_guid { get; set; }

    public long lo_operation_seqid { get; set; }

    public long? lo_operation_id { get; set; }

    public long lo_group_operation_seqid { get; set; }

    public DateTimeOffset lo_datetime { get; set; }

    public int lo_venue_id { get; set; }

    [StringLength(20)]
    public string lo_operation_type { get; set; } = null!;

    [StringLength(20)]
    public string lo_operation_subtype { get; set; } = null!;

    public long? lo_reference_id1 { get; set; }

    public long? lo_reference_id2 { get; set; }

    public Guid? lo_reference_guid1 { get; set; }

    public Guid? lo_reference_guid2 { get; set; }

    public string? lo_txt_data1 { get; set; }

    public string? lo_txt_data2 { get; set; }

    [Column(TypeName = "xml")]
    public string? lo_xml_data1 { get; set; }

    [Column(TypeName = "xml")]
    public string? lo_xml_data2 { get; set; }

    public int lo_user_id { get; set; }

    public int lo_cashier_terminal_id { get; set; }

    public long lo_cashier_session_id { get; set; }

    public long lo_voucher_id { get; set; }
}
