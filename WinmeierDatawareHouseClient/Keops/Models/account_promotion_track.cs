using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("apt_account_id", "apt_promo_id")]
[Table("account_promotion_track")]
public partial class account_promotion_track
{
    [Key]
    public long apt_promo_id { get; set; }

    [Key]
    public long apt_account_id { get; set; }

    public long apt_unique_id { get; set; }

    public bool apt_pending_reward_flag { get; set; }

    [Column("apt_input_amount ", TypeName = "money")]
    public decimal apt_input_amount_ { get; set; }

    [Column(TypeName = "money")]
    public decimal apt_prize_computed { get; set; }

    [Column(TypeName = "money")]
    public decimal apt_prize_awarded { get; set; }

    [Column(TypeName = "money")]
    public decimal apt_delta_coin_in_to_next_step { get; set; }

    [Column(TypeName = "money")]
    public decimal apt_delta_prize_to_next_step { get; set; }
}
