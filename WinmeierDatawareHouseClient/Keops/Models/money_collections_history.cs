using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("mch_gaming_day", "mch_tid", "mch_money_collection_id")]
[Table("money_collections_history")]
public partial class money_collections_history
{
    [Key]
    public int mch_gaming_day { get; set; }

    [Key]
    public long mch_tid { get; set; }

    [Key]
    public long mch_money_collection_id { get; set; }

    public int? mch_status { get; set; }

    public bool? mch_deleted { get; set; }

    [Column(TypeName = "money")]
    public decimal? mch_expected_bill_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? mch_expected_re_ticket_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? mch_drop_bill_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? mch_drop_re_ticket_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? mch_expected_daily_bill_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? mch_expected_daily_re_ticket_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mch_record_inserted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mch_record_updated { get; set; }
}
