using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("mobibank_request")]
public partial class mobibank_request
{
    public long mbr_id { get; set; }

    public int mbr_terminal_id { get; set; }

    public long mbr_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mbr_time_request { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mbr_elapsed_time_request { get; set; }

    public int? mbr_area_id { get; set; }

    public int? mbr_bank_id { get; set; }

    public int? mbr_status_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? mbr_amount { get; set; }

    public int? mbr_user_id_in_progress { get; set; }

    public int? mbr_reason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mbr_finished_time_request { get; set; }

    public int? mbr_bank_transaction_type { get; set; }
}
