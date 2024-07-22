using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class machine_meter
{
    [Key]
    public int mm_terminal_id { get; set; }

    public long mm_wcp_sequence_id { get; set; }

    public long? mm_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_played_amount { get; set; }

    public long? mm_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_won_amount { get; set; }

    public long? mm_aft_to_gm_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_aft_to_gm_amount { get; set; }

    public long? mm_aft_from_gm_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_aft_from_gm_amount { get; set; }

    public long? mm_eft_to_gm_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_eft_to_gm_amount { get; set; }

    public long? mm_eft_from_gm_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_eft_from_gm_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mm_last_reported { get; set; }

    public long mm_delta_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal mm_delta_played_amount { get; set; }

    public long mm_delta_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal mm_delta_won_amount { get; set; }

    public long mm_delta_to_gm_count { get; set; }

    [Column(TypeName = "money")]
    public decimal mm_delta_to_gm_amount { get; set; }

    public long mm_delta_from_gm_count { get; set; }

    [Column(TypeName = "money")]
    public decimal mm_delta_from_gm_amount { get; set; }

    public bool mm_delta_updating { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal mm_delta_jackpot_amount { get; set; }

    public long? mm_max_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_max_played_amount { get; set; }

    public long? mm_max_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_max_won_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_max_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_progressive_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_delta_progressive_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_max_progressive_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? mm_sas_accounting_denom { get; set; }
}
