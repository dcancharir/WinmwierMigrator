using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("bns_transferred_datetime", Name = "IX_bns_transferred_datetime", AllDescending = true)]
public partial class bonuse
{
    [Key]
    public long bns_bonus_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime bns_inserted { get; set; }

    [Column(TypeName = "money")]
    public decimal bns_to_transfer_re { get; set; }

    [Column(TypeName = "money")]
    public decimal bns_to_transfer_promo_re { get; set; }

    [Column(TypeName = "money")]
    public decimal bns_to_transfer_promo_nr { get; set; }

    public int bns_source_type { get; set; }

    public long? bns_source_bigint1 { get; set; }

    public long? bns_source_bigint2 { get; set; }

    public int? bns_source_int1 { get; set; }

    public int? bns_source_int2 { get; set; }

    public int bns_target_type { get; set; }

    public int? bns_target_terminal_id { get; set; }

    public long? bns_target_account_id { get; set; }

    public int bns_transfer_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime bns_transfer_status_changed { get; set; }

    public string? bns_transfer_status_text { get; set; }

    public long bns_wcp_cmd_id_award { get; set; }

    public long bns_wcp_cmd_id_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? bns_wcp_cmd_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? bns_transferred_datetime { get; set; }

    [Column(TypeName = "money")]
    public decimal? bns_transferred_re { get; set; }

    [Column(TypeName = "money")]
    public decimal? bns_transferred_promo_re { get; set; }

    [Column(TypeName = "money")]
    public decimal? bns_transferred_promo_nr { get; set; }

    public int? bns_transferred_terminal_id { get; set; }

    public long? bns_transferred_play_session_id { get; set; }

    public long? bns_transferred_account_id { get; set; }

    public int? bns_sas_host_status { get; set; }
}
