using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Index("ac_created", Name = "IX_ac_created")]
[Index("ac_current_play_session_id", "ac_last_activity", Name = "IX_ac_current_play_session_id")]
[Index("ac_external_reference", Name = "IX_ac_external_reference")]
[Index("ac_holder_birth_date", Name = "IX_ac_holder_birth_date")]
[Index("ac_holder_id", Name = "IX_ac_holder_id")]
[Index("ac_holder_is_vip", Name = "IX_ac_holder_is_vip")]
[Index("ac_holder_level_expiration", Name = "IX_ac_holder_level_expiration")]
[Index("ac_last_activity", Name = "IX_ac_last_activity")]
[Index("ac_account_id", "ac_type", Name = "ix_accounts_id_type")]
public partial class account
{
    [Key]
    public long ac_account_id { get; set; }

    public int ac_type { get; set; }

    [StringLength(200)]
    public string? ac_holder_name { get; set; }

    public bool ac_blocked { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_not_valid_before { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_not_valid_after { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_cash_won { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_not_redeemable { get; set; }

    public byte[]? ac_timestamp { get; set; }

    [StringLength(50)]
    public string? ac_track_data { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_total_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_total_cash_out { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_initial_cash_in { get; set; }

    public bool ac_activated { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_deposit { get; set; }

    public int? ac_current_terminal_id { get; set; }

    [StringLength(50)]
    public string? ac_current_terminal_name { get; set; }

    public long? ac_current_play_session_id { get; set; }

    public int? ac_last_terminal_id { get; set; }

    [StringLength(50)]
    public string? ac_last_terminal_name { get; set; }

    public long? ac_last_play_session_id { get; set; }

    public int? ac_user_type { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_points { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_initial_not_redeemable { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ac_created { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_promo_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_promo_limit { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ac_promo_creation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ac_promo_expiration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ac_last_activity { get; set; }

    [StringLength(50)]
    public string? ac_holder_id { get; set; }

    [StringLength(50)]
    public string? ac_holder_address_01 { get; set; }

    [StringLength(100)]
    public string? ac_holder_address_02 { get; set; }

    [StringLength(50)]
    public string? ac_holder_address_03 { get; set; }

    [StringLength(50)]
    public string? ac_holder_city { get; set; }

    [StringLength(10)]
    public string? ac_holder_zip { get; set; }

    [StringLength(50)]
    public string? ac_holder_email_01 { get; set; }

    [StringLength(50)]
    public string? ac_holder_email_02 { get; set; }

    [StringLength(20)]
    public string? ac_holder_phone_number_01 { get; set; }

    [StringLength(20)]
    public string? ac_holder_phone_number_02 { get; set; }

    [StringLength(500)]
    public string? ac_holder_comments { get; set; }

    public int? ac_holder_gender { get; set; }

    public int? ac_holder_marital_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_holder_birth_date { get; set; }

    public long ac_draw_last_play_session_id { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_draw_last_play_session_remainder { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_nr_won_lock { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_nr_expiration { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_cashin_while_playing { get; set; }

    public int ac_holder_level { get; set; }

    public bool ac_card_paid { get; set; }

    public long? ac_cancellable_operation_id { get; set; }

    public long? ac_current_promotion_id { get; set; }

    public int ac_block_reason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_holder_level_expiration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_holder_level_entered { get; set; }

    public int? ac_holder_level_notify { get; set; }

    [StringLength(12)]
    public string? ac_pin { get; set; }

    public int? ac_pin_failures { get; set; }

    [StringLength(50)]
    public string? ac_holder_name1 { get; set; }

    [StringLength(50)]
    public string? ac_holder_name2 { get; set; }

    [StringLength(50)]
    public string? ac_holder_name3 { get; set; }

    [StringLength(50)]
    public string? ac_holder_id1 { get; set; }

    [StringLength(50)]
    public string? ac_holder_id2 { get; set; }

    public long? ac_holder_document_id1 { get; set; }

    public long? ac_holder_document_id2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_nr2_expiration { get; set; }

    public long? ac_recommended_by { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_re_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_promo_re_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_promo_nr_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_played { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_won { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_re_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_re_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_nr_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_re_to_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_re_to_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_nr_to_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_re_from_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_re_from_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_nr_from_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_re_played { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_nr_played { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_re_won { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_nr_won { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_re_cancellable { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_re_cancellable { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_nr_cancellable { get; set; }

    public long ac_in_session_cancellable_transaction_id { get; set; }

    public int ac_holder_id_type { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_promo_ini_re_balance { get; set; }

    public bool? ac_holder_is_vip { get; set; }

    [StringLength(15)]
    public string? ac_holder_title { get; set; }

    [StringLength(50)]
    public string? ac_holder_name4 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_holder_wedding_date { get; set; }

    public int? ac_holder_phone_type_01 { get; set; }

    public int? ac_holder_phone_type_02 { get; set; }

    [StringLength(50)]
    public string? ac_holder_state { get; set; }

    [StringLength(50)]
    public string? ac_holder_country { get; set; }

    [StringLength(50)]
    public string? ac_holder_address_01_alt { get; set; }

    [StringLength(50)]
    public string? ac_holder_address_02_alt { get; set; }

    [StringLength(50)]
    public string? ac_holder_address_03_alt { get; set; }

    [StringLength(50)]
    public string? ac_holder_city_alt { get; set; }

    [StringLength(10)]
    public string? ac_holder_zip_alt { get; set; }

    [StringLength(50)]
    public string? ac_holder_state_alt { get; set; }

    [StringLength(50)]
    public string? ac_holder_country_alt { get; set; }

    public bool? ac_holder_is_smoker { get; set; }

    [StringLength(25)]
    public string? ac_holder_nickname { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_holder_credit_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_holder_request_credit_limit { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_pin_last_modified { get; set; }

    [StringLength(25)]
    public string? ac_last_activity_site_id { get; set; }

    [StringLength(25)]
    public string? ac_creation_site_id { get; set; }

    [StringLength(25)]
    public string? ac_last_update_site_id { get; set; }

    [StringLength(50)]
    public string? ac_external_reference { get; set; }

    public int? ac_points_status { get; set; }

    public bool? ac_ms_has_local_changes { get; set; }

    public Guid? ac_ms_change_guid { get; set; }

    public int? ac_ms_created_on_site_id { get; set; }

    public int? ac_ms_modified_on_site_id { get; set; }

    public int? ac_ms_last_site_id { get; set; }

    public long? ac_ms_points_seq_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_ms_points_synchronized { get; set; }

    public long? ac_ms_personal_info_seq_id { get; set; }

    [MaxLength(20)]
    public byte[]? ac_ms_hash { get; set; }

    [StringLength(50)]
    public string? ac_holder_twitter_account { get; set; }

    [StringLength(256)]
    public string? ac_block_description { get; set; }

    [StringLength(50)]
    public string? ac_holder_occupation { get; set; }

    [StringLength(10)]
    public string? ac_holder_ext_num { get; set; }

    public int? ac_holder_nationality { get; set; }

    public int? ac_holder_birth_country { get; set; }

    public int? ac_holder_fed_entity { get; set; }

    public int? ac_holder_id1_type { get; set; }

    public int? ac_holder_id2_type { get; set; }

    [StringLength(50)]
    public string? ac_holder_id3_type { get; set; }

    [StringLength(50)]
    public string? ac_holder_id3 { get; set; }

    [StringLength(200)]
    public string? ac_beneficiary_name { get; set; }

    [StringLength(50)]
    public string? ac_beneficiary_name1 { get; set; }

    [StringLength(50)]
    public string? ac_beneficiary_name2 { get; set; }

    [StringLength(50)]
    public string? ac_beneficiary_name3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_beneficiary_birth_date { get; set; }

    public int? ac_beneficiary_gender { get; set; }

    [StringLength(50)]
    public string? ac_beneficiary_occupation { get; set; }

    public int? ac_beneficiary_id1_type { get; set; }

    [StringLength(20)]
    public string? ac_beneficiary_id1 { get; set; }

    public int? ac_beneficiary_id2_type { get; set; }

    [StringLength(20)]
    public string? ac_beneficiary_id2 { get; set; }

    [StringLength(50)]
    public string? ac_beneficiary_id3_type { get; set; }

    [StringLength(20)]
    public string? ac_beneficiary_id3 { get; set; }

    public bool ac_holder_has_beneficiary { get; set; }

    public int? ac_holder_occupation_id { get; set; }

    public int? ac_beneficiary_occupation_id { get; set; }

    public int? ac_card_replacement_count { get; set; }

    public bool? ac_show_comments_on_cashier { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_external_aml_file_updated { get; set; }

    public int? ac_holder_address_country { get; set; }

    public int ac_holder_address_validation { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_re_reserved { get; set; }

    public bool ac_mode_reserved { get; set; }

    public Guid? ac_external_aml_file_sequence { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_provision { get; set; }

    public int? ac_egm_reserved { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ac_last_update_in_local_time { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ac_last_update_in_utc_time { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_sales_chips_rounding_amount { get; set; }

    public bool ac_show_holder_name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_constancy_printed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_constancy_signed { get; set; }

    public int? ac_holder_country_phone_code { get; set; }

    public int? ac_method_contact { get; set; }

    public int ac_fiscal_address { get; set; }

    public int ac_mailing_address { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ac_tax_form_expiration_date { get; set; }

    public int? ac_holder_country_phone_code_02 { get; set; }

    public int? ac_host_assigned_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_host_assigned_date { get; set; }

    public int ac_holder_email_validation_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_holder_email_last_send { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? ac_holder_ssn { get; set; }

    public int? ac_bad_address1 { get; set; }

    public int? ac_bad_address2 { get; set; }

    public int? ac_no_mail1 { get; set; }

    public int? ac_no_mail2 { get; set; }

    public int? ac_preferred_method { get; set; }

    [StringLength(83)]
    public string? ac_holder_id_indexed { get; set; }

    [StringLength(20)]
    public string? ac_holder_ext_num_alt { get; set; }

    [Unicode(false)]
    public string? ac_holder_level_change_comments { get; set; }

    public int ac_in_session_plays_count { get; set; }

    [StringLength(50)]
    public string? ac_holder_address_01_tertiary { get; set; }

    [StringLength(50)]
    public string? ac_holder_address_02_tertiary { get; set; }

    [StringLength(50)]
    public string? ac_holder_address_03_tertiary { get; set; }

    [StringLength(20)]
    public string? ac_holder_ext_num_tertiary { get; set; }

    [StringLength(50)]
    public string? ac_holder_country_tertiary { get; set; }

    [StringLength(50)]
    public string? ac_holder_state_tertiary { get; set; }

    [StringLength(50)]
    public string? ac_holder_city_tertiary { get; set; }

    [StringLength(10)]
    public string? ac_holder_zip_tertiary { get; set; }

    public int? ac_bad_address3 { get; set; }

    public int? ac_no_mail3 { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_in_session_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_in_session_promo_ticket_re_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_in_session_promo_ticket_nr_in { get; set; }
}
