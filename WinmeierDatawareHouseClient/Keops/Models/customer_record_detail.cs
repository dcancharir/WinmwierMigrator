using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class customer_record_detail
{
    public long curd_detail_id { get; set; }

    public long curd_record_id { get; set; }

    public bool curd_deleted { get; set; }

    public int curd_type { get; set; }

    public string? curd_data { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime curd_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? curd_expiration { get; set; }

    [MaxLength(1)]
    public byte[]? curd_image { get; set; }

    public int? curd_issued_country_id { get; set; }

    public int? curd_issued_state_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? curd_issued_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? curd_verified { get; set; }

    [StringLength(100)]
    public string? curd_document_number { get; set; }

    public long? curd_detail_parent_id { get; set; }

    public Guid? curd_ms_change_guid { get; set; }

    public long? curd_ms_sequence_id { get; set; }
}
