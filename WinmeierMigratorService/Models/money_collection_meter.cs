using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class money_collection_meter
{
    [Key]
    public long mcm_session_id { get; set; }

    public long mcm_money_collection_id { get; set; }

    public long? mcm_bills_in_stacker_num { get; set; }

    public int mcm_terminal_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mcm_started { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mcm_finished { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mcm_last_reported { get; set; }

    public bool? mcm_error_reporting { get; set; }

    public long? mcm_cashable_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcm_cashable_amount { get; set; }

    public long? mcm_promo_nr_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcm_promo_nr_amount { get; set; }

    public long? mcm_promo_re_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcm_promo_re_amount { get; set; }

    public int? mcm_1_bill_num { get; set; }

    public int? mcm_2_bill_num { get; set; }

    public int? mcm_5_bill_num { get; set; }

    public int? mcm_10_bill_num { get; set; }

    public int? mcm_20_bill_num { get; set; }

    public int? mcm_25_bill_num { get; set; }

    public int? mcm_50_bill_num { get; set; }

    public int? mcm_100_bill_num { get; set; }

    public int? mcm_200_bill_num { get; set; }

    public int? mcm_250_bill_num { get; set; }

    public int? mcm_500_bill_num { get; set; }

    public int? mcm_1000_bill_num { get; set; }

    public int? mcm_2000_bill_num { get; set; }

    public int? mcm_2500_bill_num { get; set; }

    public int? mcm_5000_bill_num { get; set; }

    public int? mcm_10000_bill_num { get; set; }

    public int? mcm_20000_bill_num { get; set; }

    public int? mcm_25000_bill_num { get; set; }

    public int? mcm_50000_bill_num { get; set; }

    public int? mcm_100000_bill_num { get; set; }

    public int? mcm_200000_bill_num { get; set; }

    public int? mcm_250000_bill_num { get; set; }

    public int? mcm_500000_bill_num { get; set; }

    public int? mcm_1000000_bill_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcm_total_coin_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcm_out_bills { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcm_out_coins { get; set; }

    [Column(TypeName = "money")]
    public decimal? mcm_out_cents { get; set; }
}
