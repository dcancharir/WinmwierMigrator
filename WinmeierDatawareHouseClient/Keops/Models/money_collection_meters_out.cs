using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("money_collection_meters_out")]
public partial class money_collection_meters_out
{
    [Key]
    public long mcmo_session_id { get; set; }

    public long mcmo_money_collection_id { get; set; }

    public long? mcmo_bills_in_stacker_num { get; set; }

    public int mcmo_terminal_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mcmo_started { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mcmo_finished { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mcmo_last_reported { get; set; }

    public bool? mcmo_error_reporting { get; set; }

    public long? mcmo_cashable_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcmo_cashable_amount { get; set; }

    public long? mcmo_promo_nr_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcmo_promo_nr_amount { get; set; }

    public long? mcmo_promo_re_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcmo_promo_re_amount { get; set; }

    public int? mcmo_1_bill_num { get; set; }

    public int? mcmo_2_bill_num { get; set; }

    public int? mcmo_5_bill_num { get; set; }

    public int? mcmo_10_bill_num { get; set; }

    public int? mcmo_20_bill_num { get; set; }

    public int? mcmo_25_bill_num { get; set; }

    public int? mcmo_50_bill_num { get; set; }

    public int? mcmo_100_bill_num { get; set; }

    public int? mcmo_200_bill_num { get; set; }

    public int? mcmo_250_bill_num { get; set; }

    public int? mcmo_500_bill_num { get; set; }

    public int? mcmo_1000_bill_num { get; set; }

    public int? mcmo_2000_bill_num { get; set; }

    public int? mcmo_2500_bill_num { get; set; }

    public int? mcmo_5000_bill_num { get; set; }

    public int? mcmo_10000_bill_num { get; set; }

    public int? mcmo_20000_bill_num { get; set; }

    public int? mcmo_25000_bill_num { get; set; }

    public int? mcmo_50000_bill_num { get; set; }

    public int? mcmo_100000_bill_num { get; set; }

    public int? mcmo_200000_bill_num { get; set; }

    public int? mcmo_250000_bill_num { get; set; }

    public int? mcmo_500000_bill_num { get; set; }

    public int? mcmo_1000000_bill_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcmo_total_coin_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcmo_out_bills { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcmo_out_coins { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcmo_out_cents { get; set; }
}
