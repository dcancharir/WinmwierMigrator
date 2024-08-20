using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("TMP_TERMINALS_TO_BASE_NAME")]
public partial class TMP_TERMINALS_TO_BASE_NAME
{
    public int te_terminal_id { get; set; }

    public int te_type { get; set; }

    public int? te_server_id { get; set; }

    [StringLength(50)]
    public string? te_name { get; set; }

    [StringLength(40)]
    public string? te_external_id { get; set; }

    public bool te_blocked { get; set; }

    public byte[]? te_timestamp { get; set; }

    public bool te_active { get; set; }

    [StringLength(50)]
    public string? te_provider_id { get; set; }

    public short? te_client_id { get; set; }

    public short? te_build_id { get; set; }

    public short te_terminal_type { get; set; }

    [StringLength(50)]
    public string? te_vendor_id { get; set; }

    [StringLength(40)]
    public string? te_unique_external_id { get; set; }

    public int te_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? te_retirement_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? te_retirement_requested { get; set; }

    [Column(TypeName = "money")]
    public decimal? te_denomination { get; set; }

    [StringLength(40)]
    public string? te_multi_denomination { get; set; }

    [StringLength(40)]
    public string? te_program { get; set; }

    [Column(TypeName = "money")]
    public decimal? te_theoretical_payout { get; set; }

    [Column(TypeName = "numeric(20, 4)")]
    public decimal? te_theoretical_hold { get; set; }

    public int? te_prov_id { get; set; }

    public int te_bank_id { get; set; }

    [StringLength(20)]
    public string? te_floor_id { get; set; }

    public int te_game_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime te_activation_date { get; set; }

    public long? te_current_account_id { get; set; }

    public long? te_current_play_session_id { get; set; }

    [StringLength(50)]
    public string? te_registration_code { get; set; }

    public int te_sas_flags { get; set; }

    [StringLength(50)]
    public string? te_serial_number { get; set; }

    [StringLength(50)]
    public string? te_cabinet_type { get; set; }

    [Column(TypeName = "numeric(7, 4)")]
    public decimal? te_jackpot_contribution_pct { get; set; }

    public int te_contract_type { get; set; }

    [StringLength(50)]
    public string? te_contract_id { get; set; }

    [StringLength(50)]
    public string? te_order_number { get; set; }

    public bool te_wxp_reported { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime te_wxp_reported_status_datetime { get; set; }

    public long te_wxp_reported_status { get; set; }

    public long? te_sequence_id { get; set; }

    public int? te_validation_type { get; set; }

    public bool? te_allowed_cashable_emission { get; set; }

    public bool? te_allowed_promo_emission { get; set; }

    public bool? te_allowed_redemption { get; set; }

    [Column(TypeName = "money")]
    public decimal? te_max_allowed_ti { get; set; }

    [Column(TypeName = "money")]
    public decimal? te_max_allowed_to { get; set; }

    [StringLength(10)]
    public string? te_sas_version { get; set; }

    [StringLength(10)]
    public string? te_sas_machine_name { get; set; }

    public int? te_bonus_flags { get; set; }

    public int? te_features_bytes { get; set; }

    public long? te_virtual_account_id { get; set; }

    public int te_sas_flags_use_site_default { get; set; }

    public int? te_authentication_method { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? te_authentication_seed { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? te_authentication_signature { get; set; }

    public int? te_authentication_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? te_authentication_last_checked { get; set; }

    [StringLength(50)]
    public string? te_machine_id { get; set; }

    public int? te_position { get; set; }

    [Column(TypeName = "money")]
    public decimal? te_top_award { get; set; }

    [Column(TypeName = "money")]
    public decimal? te_max_bet { get; set; }

    [StringLength(50)]
    public string? te_number_lines { get; set; }

    [StringLength(50)]
    public string? te_game_theme { get; set; }

    public long? te_account_promotion_id { get; set; }

    public long? te_machine_asset_number { get; set; }

    public long? te_asset_number { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? te_machine_serial_number { get; set; }

    public long te_meter_delta_id { get; set; }
}
