using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("te_external_id", Name = "IX_terminal_external_id")]
[Index("te_name", Name = "IX_terminal_name", IsUnique = true)]
[Index("te_terminal_id", "te_provider_id", Name = "IX_terminal_provider_id", IsUnique = true)]
[Index("te_unique_external_id", Name = "IX_terminal_unique_ext_id", IsUnique = true)]
public partial class terminal
{
    [Key]
    public int te_terminal_id { get; set; }

    public int te_type { get; set; }

    public int? te_server_id { get; set; }

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

    public bool te_wxp_reported { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime te_wxp_reported_status_datetime { get; set; }

    public long te_wxp_reported_status { get; set; }

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

    public int te_master_id { get; set; }

    public int te_change_id { get; set; }

    [StringLength(40)]
    public string te_base_name { get; set; } = null!;

    [StringLength(50)]
    public string? te_name { get; set; }

    public int te_transfer_status { get; set; }

    public int? te_smib2egm_comm_type { get; set; }

    public long? te_smib2egm_conf_id { get; set; }

    public int te_last_game_played_id { get; set; }

    [StringLength(50)]
    public string? te_brand_code { get; set; }

    [StringLength(50)]
    public string? te_model { get; set; }

    public int? te_manufacture_year { get; set; }

    public bool? te_met_homologated { get; set; }

    [StringLength(50)]
    public string? te_bet_code { get; set; }

    public bool te_coin_collection { get; set; }

    public int? te_terminal_currency_id { get; set; }

    [StringLength(3)]
    public string te_iso_code { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? te_equity_percentage { get; set; }

    [Column(TypeName = "money")]
    public decimal? te_sas_accounting_denom { get; set; }

    public int te_tito_host_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? te_min_allowed_ti { get; set; }

    public bool? te_allow_truncate { get; set; }

    [Column(TypeName = "money")]
    public decimal? te_min_denomination { get; set; }

    public bool? te_chk_equity_percentage { get; set; }

    public long? te_reserve_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? te_reservation_expires { get; set; }

    public int? te_multiseat_id { get; set; }

    public int? te_manufacture_month { get; set; }

    public int? te_manufacture_day { get; set; }

    [InverseProperty("te_server")]
    public virtual ICollection<terminal> Inversete_server { get; set; } = new List<terminal>();

    [InverseProperty("ctx_terminal")]
    public virtual ICollection<cj_transaction> cj_transactions { get; set; } = new List<cj_transaction>();

    [InverseProperty("eh_terminal")]
    public virtual ICollection<event_history> event_histories { get; set; } = new List<event_history>();

    [InverseProperty("gm_terminal")]
    public virtual ICollection<game_meter> game_meters { get; set; } = new List<game_meter>();

    [InverseProperty("hpc_terminal")]
    public virtual hpc_meter? hpc_meter { get; set; }

    [InverseProperty("me_terminal")]
    public virtual ICollection<meter> meters { get; set; } = new List<meter>();

    [InverseProperty("ps_terminal")]
    public virtual ICollection<play_session> play_sessions { get; set; } = new List<play_session>();

    [InverseProperty("pl_terminal")]
    public virtual ICollection<play> plays { get; set; } = new List<play>();

    [InverseProperty("rtt_terminal")]
    public virtual ICollection<reserved_terminal_transaction> reserved_terminal_transactions { get; set; } = new List<reserved_terminal_transaction>();

    [ForeignKey("te_bank_id")]
    [InverseProperty("terminals")]
    public virtual bank te_bank { get; set; } = null!;

    [ForeignKey("te_server_id")]
    [InverseProperty("Inversete_server")]
    public virtual terminal? te_server { get; set; }

    [InverseProperty("w2m_terminal")]
    public virtual ICollection<wc2_message> wc2_messages { get; set; } = new List<wc2_message>();

    [InverseProperty("w2s_terminal")]
    public virtual ICollection<wc2_session> wc2_sessions { get; set; } = new List<wc2_session>();

    [InverseProperty("w2tx_terminal")]
    public virtual ICollection<wc2_transaction> wc2_transactions { get; set; } = new List<wc2_transaction>();

    [InverseProperty("wm_terminal")]
    public virtual ICollection<wcp_message> wcp_messages { get; set; } = new List<wcp_message>();

    [InverseProperty("ws_terminal")]
    public virtual ICollection<wcp_session> wcp_sessions { get; set; } = new List<wcp_session>();

    [InverseProperty("wtx_terminal")]
    public virtual ICollection<wcp_transaction> wcp_transactions { get; set; } = new List<wcp_transaction>();
}
