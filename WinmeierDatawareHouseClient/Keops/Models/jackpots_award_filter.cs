using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class jackpots_award_filter
{
    public int jaf_id { get; set; }

    public int jaf_jackpot_id { get; set; }

    public bool jaf_exclude_anonymous_accounts { get; set; }

    public bool jaf_exclude_accounts_with_promo { get; set; }

    [Column(TypeName = "money")]
    public decimal? jaf_min_occupancy { get; set; }

    public int? jaf_by_gender { get; set; }

    public int? jaf_by_date_of_birth { get; set; }

    public bool? jaf_age_range { get; set; }

    public int? jaf_older_than { get; set; }

    public int? jaf_and_smaller_than { get; set; }

    public int? jaf_smaller_than { get; set; }

    public int? jaf_or_older_than { get; set; }

    public int? jaf_by_creation_date { get; set; }

    public bool? jaf_just_day_of_creation { get; set; }

    public int? jaf_day_of_creation_plus { get; set; }

    public bool? jaf_any_day_of_month { get; set; }

    public bool? jaf_day_and_month { get; set; }

    public int? jaf_creation_between_this { get; set; }

    public int? jaf_creation_between_that { get; set; }

    public int? jaf_selection_egm_type { get; set; }

    [Column(TypeName = "xml")]
    public string? jaf_selected_egm { get; set; }

    [Column(TypeName = "money")]
    public decimal jaf_minimum_bet { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? jaf_last_update { get; set; }
}
