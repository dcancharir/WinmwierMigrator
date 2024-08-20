using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WinmeierDataWarehouseClient.Keops.Models;
namespace WinmeierDatawareHouseClient.Keops.Context;

public partial class wgdb_000_keopsContext : DbContext
{
    public wgdb_000_keopsContext()
    {
    }

    public wgdb_000_keopsContext(DbContextOptions<wgdb_000_keopsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AFIP_DETALLE_TERMINALE> AFIP_DETALLE_TERMINALEs { get; set; }

    public virtual DbSet<BONUSING_GAMES_LIMIT> BONUSING_GAMES_LIMITs { get; set; }

    public virtual DbSet<Card_Generation> Card_Generations { get; set; }

    public virtual DbSet<DELETE_BUFFER_HandPays_TEMP> DELETE_BUFFER_HandPays_TEMPs { get; set; }

    public virtual DbSet<DELETE_BUFFER_TSMH_TEMP> DELETE_BUFFER_TSMH_TEMPs { get; set; }

    public virtual DbSet<ErrorHandling> ErrorHandlings { get; set; }

    public virtual DbSet<Install_components_info> Install_components_infos { get; set; }

    public virtual DbSet<JACKPOT_TAX_TEMPLATE_BKP_2022_03> JACKPOT_TAX_TEMPLATE_BKP_2022_03s { get; set; }

    public virtual DbSet<MIGRATION_ACCOUNT> MIGRATION_ACCOUNTs { get; set; }

    public virtual DbSet<MIGRATION_TABLE> MIGRATION_TABLEs { get; set; }

    public virtual DbSet<PRELIC> PRELICs { get; set; }

    public virtual DbSet<PROVIDERS_GAMES_FINALLY> PROVIDERS_GAMES_FINALLies { get; set; }

    public virtual DbSet<RESULTADO> RESULTADOs { get; set; }

    public virtual DbSet<Resultado_fragment> Resultado_fragments { get; set; }

    public virtual DbSet<Resultado_size> Resultado_sizes { get; set; }

    public virtual DbSet<SqlServerVersion> SqlServerVersions { get; set; }

    public virtual DbSet<TABLESFRAGMENT> TABLESFRAGMENTs { get; set; }

    public virtual DbSet<TABLESIZE> TABLESIZEs { get; set; }

    public virtual DbSet<TEMP_bonusing_games_TIER_LEVEL> TEMP_bonusing_games_TIER_LEVELs { get; set; }

    public virtual DbSet<TEMP_buckets_multiplier_schedule_TIER_LEVEL> TEMP_buckets_multiplier_schedule_TIER_LEVELs { get; set; }

    public virtual DbSet<TEMP_buckets_multiplier_to_apply_TIER_LEVEL> TEMP_buckets_multiplier_to_apply_TIER_LEVELs { get; set; }

    public virtual DbSet<TMP_TERMINALS_TO_BASE_NAME> TMP_TERMINALS_TO_BASE_NAMEs { get; set; }

    public virtual DbSet<UNDO_PIN_PAD_TRANSACTION> UNDO_PIN_PAD_TRANSACTIONs { get; set; }

    public virtual DbSet<account> accounts { get; set; }

    public virtual DbSet<account_buckets_expired_control> account_buckets_expired_controls { get; set; }

    public virtual DbSet<account_buckets_expired_list> account_buckets_expired_lists { get; set; }

    public virtual DbSet<account_document> account_documents { get; set; }

    public virtual DbSet<account_documents_backup> account_documents_backups { get; set; }

    public virtual DbSet<account_documents_to_upgrade> account_documents_to_upgrades { get; set; }

    public virtual DbSet<account_flag> account_flags { get; set; }

    public virtual DbSet<account_major_prize> account_major_prizes { get; set; }

    public virtual DbSet<account_movement> account_movements { get; set; }

    public virtual DbSet<account_movements_by_time> account_movements_by_times { get; set; }

    public virtual DbSet<account_operation> account_operations { get; set; }

    public virtual DbSet<account_payment_order> account_payment_orders { get; set; }

    public virtual DbSet<account_photo> account_photos { get; set; }

    public virtual DbSet<account_points_cache> account_points_caches { get; set; }

    public virtual DbSet<account_points_expired_control> account_points_expired_controls { get; set; }

    public virtual DbSet<account_points_expired_list> account_points_expired_lists { get; set; }

    public virtual DbSet<account_promotion> account_promotions { get; set; }

    public virtual DbSet<account_promotion_downloaded> account_promotion_downloadeds { get; set; }

    public virtual DbSet<account_promotion_track> account_promotion_tracks { get; set; }

    public virtual DbSet<account_promotion_track_interval> account_promotion_track_intervals { get; set; }

    public virtual DbSet<afip_log> afip_logs { get; set; }

    public virtual DbSet<alarm> alarms { get; set; }

    public virtual DbSet<alarm_catalog> alarm_catalogs { get; set; }

    public virtual DbSet<alarm_catalog_per_category> alarm_catalog_per_categories { get; set; }

    public virtual DbSet<alarm_category> alarm_categories { get; set; }

    public virtual DbSet<alarm_group> alarm_groups { get; set; }

    public virtual DbSet<alesis_parameter> alesis_parameters { get; set; }

    public virtual DbSet<alesis_terminal> alesis_terminals { get; set; }

    public virtual DbSet<aml_daily> aml_dailies { get; set; }

    public virtual DbSet<aml_monthly> aml_monthlies { get; set; }

    public virtual DbSet<application> applications { get; set; }

    public virtual DbSet<area> areas { get; set; }

    public virtual DbSet<audit_3g> audit_3gs { get; set; }

    public virtual DbSet<authorization_audit> authorization_audits { get; set; }

    public virtual DbSet<authorization_limit> authorization_limits { get; set; }

    public virtual DbSet<auto_print_cash_out_receipt_report> auto_print_cash_out_receipt_reports { get; set; }

    public virtual DbSet<auto_print_pending_generation_voucher> auto_print_pending_generation_vouchers { get; set; }

    public virtual DbSet<auto_print_pending_print_voucher> auto_print_pending_print_vouchers { get; set; }

    public virtual DbSet<bank> banks { get; set; }

    public virtual DbSet<bank_account> bank_accounts { get; set; }

    public virtual DbSet<bank_transaction> bank_transactions { get; set; }

    public virtual DbSet<blacklist_bind> blacklist_binds { get; set; }

    public virtual DbSet<blacklist_file_imported> blacklist_file_importeds { get; set; }

    public virtual DbSet<blacklist_file_imported_type> blacklist_file_imported_types { get; set; }

    public virtual DbSet<blacklist_internal_block_list> blacklist_internal_block_lists { get; set; }

    public virtual DbSet<blacklist_positive_case> blacklist_positive_cases { get; set; }

    public virtual DbSet<blacklist_rule> blacklist_rules { get; set; }

    public virtual DbSet<blacklist_rules_bind> blacklist_rules_binds { get; set; }

    public virtual DbSet<blacklist_rules_description> blacklist_rules_descriptions { get; set; }

    public virtual DbSet<blocked_table> blocked_tables { get; set; }

    public virtual DbSet<bonuse> bonuses { get; set; }

    public virtual DbSet<bonusing_game> bonusing_games { get; set; }

    public virtual DbSet<bonusing_games_prize> bonusing_games_prizes { get; set; }

    public virtual DbSet<bonusing_games_session> bonusing_games_sessions { get; set; }

    public virtual DbSet<bucket> buckets { get; set; }

    public virtual DbSet<bucket01_daily> bucket01_dailies { get; set; }

    public virtual DbSet<bucket_level> bucket_levels { get; set; }

    public virtual DbSet<bucket_limits_profile> bucket_limits_profiles { get; set; }

    public virtual DbSet<buckets_multiplier_schedule> buckets_multiplier_schedules { get; set; }

    public virtual DbSet<buckets_multiplier_to_apply> buckets_multiplier_to_applies { get; set; }

    public virtual DbSet<buffer_alarm> buffer_alarms { get; set; }

    public virtual DbSet<buffer_cashier_movement> buffer_cashier_movements { get; set; }

    public virtual DbSet<buffer_handpay> buffer_handpays { get; set; }

    public virtual DbSet<buffer_tax_report_bill_in> buffer_tax_report_bill_ins { get; set; }

    public virtual DbSet<buffer_terminal_sas_meter> buffer_terminal_sas_meters { get; set; }

    public virtual DbSet<buffer_terminal_sas_meters_history> buffer_terminal_sas_meters_histories { get; set; }

    public virtual DbSet<buffer_terminals_connected> buffer_terminals_connecteds { get; set; }

    public virtual DbSet<buffer_terminals_time_disconnected> buffer_terminals_time_disconnecteds { get; set; }

    public virtual DbSet<buffer_ticket> buffer_tickets { get; set; }

    public virtual DbSet<buffer_wc2Session> buffer_wc2Sessions { get; set; }

    public virtual DbSet<buffer_wcpSession> buffer_wcpSessions { get; set; }

    public virtual DbSet<buffer_wcp_control_mark> buffer_wcp_control_marks { get; set; }

    public virtual DbSet<c2_card> c2_cards { get; set; }

    public virtual DbSet<c2_draw_audit> c2_draw_audits { get; set; }

    public virtual DbSet<c2_draw_audit_play> c2_draw_audit_plays { get; set; }

    public virtual DbSet<c2_jackpot_counter> c2_jackpot_counters { get; set; }

    public virtual DbSet<c2_jackpot_history> c2_jackpot_histories { get; set; }

    public virtual DbSet<c2_jackpot_instance> c2_jackpot_instances { get; set; }

    public virtual DbSet<c2_jackpot_parameter> c2_jackpot_parameters { get; set; }

    public virtual DbSet<c2_winning_pattern> c2_winning_patterns { get; set; }

    public virtual DbSet<c2go_card> c2go_cards { get; set; }

    public virtual DbSet<cage_cashier_movement_relation> cage_cashier_movement_relations { get; set; }

    public virtual DbSet<cage_concept> cage_concepts { get; set; }

    public virtual DbSet<cage_concept_movement_detail> cage_concept_movement_details { get; set; }

    public virtual DbSet<cage_currency> cage_currencies { get; set; }

    public virtual DbSet<cage_meter> cage_meters { get; set; }

    public virtual DbSet<cage_movement> cage_movements { get; set; }

    public virtual DbSet<cage_movement_detail> cage_movement_details { get; set; }

    public virtual DbSet<cage_movement_template> cage_movement_templates { get; set; }

    public virtual DbSet<cage_movementcashier_movement> cage_movementcashier_movements { get; set; }

    public virtual DbSet<cage_pending_movement> cage_pending_movements { get; set; }

    public virtual DbSet<cage_session> cage_sessions { get; set; }

    public virtual DbSet<cage_session_meter> cage_session_meters { get; set; }

    public virtual DbSet<cage_source_target> cage_source_targets { get; set; }

    public virtual DbSet<cage_source_target_concept> cage_source_target_concepts { get; set; }

    public virtual DbSet<cage_stock> cage_stocks { get; set; }

    public virtual DbSet<cage_vault> cage_vaults { get; set; }

    public virtual DbSet<card> cards { get; set; }

    public virtual DbSet<card_item> card_items { get; set; }

    public virtual DbSet<card_template> card_templates { get; set; }

    public virtual DbSet<cards_replacement_history> cards_replacement_histories { get; set; }

    public virtual DbSet<carousel> carousels { get; set; }

    public virtual DbSet<carousel_resource> carousel_resources { get; set; }

    public virtual DbSet<cashdesk_draw> cashdesk_draws { get; set; }

    public virtual DbSet<cashier_movement> cashier_movements { get; set; }

    public virtual DbSet<cashier_movements_grouped_by_hour> cashier_movements_grouped_by_hours { get; set; }

    public virtual DbSet<cashier_movements_grouped_by_session_id> cashier_movements_grouped_by_session_ids { get; set; }

    public virtual DbSet<cashier_movements_pending_history> cashier_movements_pending_histories { get; set; }

    public virtual DbSet<cashier_session> cashier_sessions { get; set; }

    public virtual DbSet<cashier_session_transfer> cashier_session_transfers { get; set; }

    public virtual DbSet<cashier_sessions_by_currency> cashier_sessions_by_currencies { get; set; }

    public virtual DbSet<cashier_terminal> cashier_terminals { get; set; }

    public virtual DbSet<cashier_terminal_money> cashier_terminal_moneys { get; set; }

    public virtual DbSet<cashier_voucher> cashier_vouchers { get; set; }

    public virtual DbSet<catalog> catalogs { get; set; }

    public virtual DbSet<catalog_item> catalog_items { get; set; }

    public virtual DbSet<cfdi_register> cfdi_registers { get; set; }

    public virtual DbSet<chip> chips { get; set; }

    public virtual DbSet<chips_set> chips_sets { get; set; }

    public virtual DbSet<chips_sets_chip> chips_sets_chips { get; set; }

    public virtual DbSet<chips_stock> chips_stocks { get; set; }

    public virtual DbSet<cj_parameter> cj_parameters { get; set; }

    public virtual DbSet<cj_queue> cj_queues { get; set; }

    public virtual DbSet<cj_transaction> cj_transactions { get; set; }

    public virtual DbSet<closing_stock> closing_stocks { get; set; }

    public virtual DbSet<countr> countrs { get; set; }

    public virtual DbSet<countr_log> countr_logs { get; set; }

    public virtual DbSet<countr_session> countr_sessions { get; set; }

    public virtual DbSet<countr_transaction> countr_transactions { get; set; }

    public virtual DbSet<country> countries { get; set; }

    public virtual DbSet<country_zip_code_list> country_zip_code_lists { get; set; }

    public virtual DbSet<country_zip_code_setting> country_zip_code_settings { get; set; }

    public virtual DbSet<credit_line> credit_lines { get; set; }

    public virtual DbSet<credit_line_movement> credit_line_movements { get; set; }

    public virtual DbSet<csv_control_file> csv_control_files { get; set; }

    public virtual DbSet<currency> currencies { get; set; }

    public virtual DbSet<currency_denomination> currency_denominations { get; set; }

    public virtual DbSet<currency_exchange> currency_exchanges { get; set; }

    public virtual DbSet<currency_exchange_audit> currency_exchange_audits { get; set; }

    public virtual DbSet<customer> customers { get; set; }

    public virtual DbSet<customer_account> customer_accounts { get; set; }

    public virtual DbSet<customer_account_history> customer_account_histories { get; set; }

    public virtual DbSet<customer_bucket> customer_buckets { get; set; }

    public virtual DbSet<customer_bucket_by_gaming_day> customer_bucket_by_gaming_days { get; set; }

    public virtual DbSet<customer_entrance> customer_entrances { get; set; }

    public virtual DbSet<customer_entrances_price> customer_entrances_prices { get; set; }

    public virtual DbSet<customer_notice> customer_notices { get; set; }

    public virtual DbSet<customer_notices_history> customer_notices_histories { get; set; }

    public virtual DbSet<customer_notices_priority> customer_notices_priorities { get; set; }

    public virtual DbSet<customer_preferences_catalog> customer_preferences_catalogs { get; set; }

    public virtual DbSet<customer_record> customer_records { get; set; }

    public virtual DbSet<customer_record_detail> customer_record_details { get; set; }

    public virtual DbSet<customer_record_details_history> customer_record_details_histories { get; set; }

    public virtual DbSet<customer_records_history> customer_records_histories { get; set; }

    public virtual DbSet<customer_visit> customer_visits { get; set; }

    public virtual DbSet<customer_visit_egm_stat> customer_visit_egm_stats { get; set; }

    public virtual DbSet<customer_visit_gt_stat> customer_visit_gt_stats { get; set; }

    public virtual DbSet<customers_sum_balance> customers_sum_balances { get; set; }

    public virtual DbSet<daily_meter> daily_meters { get; set; }

    public virtual DbSet<dates_by_config> dates_by_configs { get; set; }

    public virtual DbSet<db_user> db_users { get; set; }

    public virtual DbSet<db_version> db_versions { get; set; }

    public virtual DbSet<db_version_interface_3g> db_version_interface_3gs { get; set; }

    public virtual DbSet<db_version_mywinsy> db_version_mywinsys { get; set; }

    public virtual DbSet<db_version_smartfloor> db_version_smartfloors { get; set; }

    public virtual DbSet<document> documents { get; set; }

    public virtual DbSet<draw> draws { get; set; }

    public virtual DbSet<draw_account_restriction> draw_account_restrictions { get; set; }

    public virtual DbSet<draw_pending_tickets_notification> draw_pending_tickets_notifications { get; set; }

    public virtual DbSet<draw_period_of_study> draw_period_of_studies { get; set; }

    public virtual DbSet<draw_ticket> draw_tickets { get; set; }

    public virtual DbSet<draw_tickets_pending> draw_tickets_pendings { get; set; }

    public virtual DbSet<drawing_flag> drawing_flags { get; set; }

    public virtual DbSet<draws_execution> draws_executions { get; set; }

    public virtual DbSet<draws_executions_entry> draws_executions_entries { get; set; }

    public virtual DbSet<draws_launch_parameter> draws_launch_parameters { get; set; }

    public virtual DbSet<drop_movement> drop_movements { get; set; }

    public virtual DbSet<egm_control_mark> egm_control_marks { get; set; }

    public virtual DbSet<egm_daily> egm_dailies { get; set; }

    public virtual DbSet<egm_location_format_config> egm_location_format_configs { get; set; }

    public virtual DbSet<egm_meters_by_day> egm_meters_by_days { get; set; }

    public virtual DbSet<egm_meters_by_period> egm_meters_by_periods { get; set; }

    public virtual DbSet<egm_meters_max_value> egm_meters_max_values { get; set; }

    public virtual DbSet<egm_stage_daily> egm_stage_dailies { get; set; }

    public virtual DbSet<egm_stage_meters_by_day> egm_stage_meters_by_days { get; set; }

    public virtual DbSet<egm_stage_meters_by_period> egm_stage_meters_by_periods { get; set; }

    public virtual DbSet<elp01_play_session> elp01_play_sessions { get; set; }

    public virtual DbSet<elp01_space_request> elp01_space_requests { get; set; }

    public virtual DbSet<elp01_voucher> elp01_vouchers { get; set; }

    public virtual DbSet<event_history> event_histories { get; set; }

    public virtual DbSet<external_cashier_stacker_collection> external_cashier_stacker_collections { get; set; }

    public virtual DbSet<external_cashier_subscription_method> external_cashier_subscription_methods { get; set; }

    public virtual DbSet<external_notification_communication> external_notification_communications { get; set; }

    public virtual DbSet<external_notification_notification> external_notification_notifications { get; set; }

    public virtual DbSet<external_notification_types_to_notify> external_notification_types_to_notifies { get; set; }

    public virtual DbSet<external_requests_log> external_requests_logs { get; set; }

    public virtual DbSet<external_validation_operation> external_validation_operations { get; set; }

    public virtual DbSet<fbm_log> fbm_logs { get; set; }

    public virtual DbSet<federal_state> federal_states { get; set; }

    public virtual DbSet<field_validator> field_validators { get; set; }

    public virtual DbSet<field_validator_request> field_validator_requests { get; set; }

    public virtual DbSet<filter_template> filter_templates { get; set; }

    public virtual DbSet<filter_templates_default> filter_templates_defaults { get; set; }

    public virtual DbSet<financialReport> financialReports { get; set; }

    public virtual DbSet<financial_report> financial_reports { get; set; }

    public virtual DbSet<flag> flags { get; set; }

    public virtual DbSet<floor_neighborhood> floor_neighborhoods { get; set; }

    public virtual DbSet<food_beverage_catalog> food_beverage_catalogs { get; set; }

    public virtual DbSet<food_beverage_instances_sync> food_beverage_instances_syncs { get; set; }

    public virtual DbSet<food_beverage_order> food_beverage_orders { get; set; }

    public virtual DbSet<game> games { get; set; }

    public virtual DbSet<game_meter> game_meters { get; set; }

    public virtual DbSet<game_play_session> game_play_sessions { get; set; }

    public virtual DbSet<game_type> game_types { get; set; }

    public virtual DbSet<gamegateway_bet> gamegateway_bets { get; set; }

    public virtual DbSet<gamegateway_command_message> gamegateway_command_messages { get; set; }

    public virtual DbSet<gamegateway_game> gamegateway_games { get; set; }

    public virtual DbSet<gamegateway_game_instance> gamegateway_game_instances { get; set; }

    public virtual DbSet<gamegateway_log> gamegateway_logs { get; set; }

    public virtual DbSet<gamegateway_terminal_list> gamegateway_terminal_lists { get; set; }

    public virtual DbSet<gaming_hall_group> gaming_hall_groups { get; set; }

    public virtual DbSet<gaming_hall_group_added> gaming_hall_group_addeds { get; set; }

    public virtual DbSet<gaming_hall_group_detail> gaming_hall_group_details { get; set; }

    public virtual DbSet<gaming_table> gaming_tables { get; set; }

    public virtual DbSet<gaming_table_bet> gaming_table_bets { get; set; }

    public virtual DbSet<gaming_table_chips_set> gaming_table_chips_sets { get; set; }

    public virtual DbSet<gaming_table_configuration> gaming_table_configurations { get; set; }

    public virtual DbSet<gaming_tables_connected> gaming_tables_connecteds { get; set; }

    public virtual DbSet<gaming_tables_dealer_session> gaming_tables_dealer_sessions { get; set; }

    public virtual DbSet<gaming_tables_dealer_sessions_by_currency> gaming_tables_dealer_sessions_by_currencies { get; set; }

    public virtual DbSet<gaming_tables_session> gaming_tables_sessions { get; set; }

    public virtual DbSet<gaming_tables_sessions_by_currency> gaming_tables_sessions_by_currencies { get; set; }

    public virtual DbSet<gaming_tables_tournament> gaming_tables_tournaments { get; set; }

    public virtual DbSet<gaming_tables_tournament_enrollment> gaming_tables_tournament_enrollments { get; set; }

    public virtual DbSet<gaming_tables_tournament_movement> gaming_tables_tournament_movements { get; set; }

    public virtual DbSet<gaming_tables_tournament_prize> gaming_tables_tournament_prizes { get; set; }

    public virtual DbSet<gaming_tables_tournament_prizes_breakdown> gaming_tables_tournament_prizes_breakdowns { get; set; }

    public virtual DbSet<gaming_tables_tournament_table> gaming_tables_tournament_tables { get; set; }

    public virtual DbSet<gaming_tables_type> gaming_tables_types { get; set; }

    public virtual DbSet<gaming_tables_win_loss> gaming_tables_win_losses { get; set; }

    public virtual DbSet<gaming_tables_win_loss_detail> gaming_tables_win_loss_details { get; set; }

    public virtual DbSet<gds_group> gds_groups { get; set; }

    public virtual DbSet<gds_group_element> gds_group_elements { get; set; }

    public virtual DbSet<gds_platform> gds_platforms { get; set; }

    public virtual DbSet<gds_schedule_detail> gds_schedule_details { get; set; }

    public virtual DbSet<gds_schedule_step> gds_schedule_steps { get; set; }

    public virtual DbSet<gds_schedule_time> gds_schedule_times { get; set; }

    public virtual DbSet<gdw> gdws { get; set; }

    public virtual DbSet<general_param> general_params { get; set; }

    public virtual DbSet<gift> gifts { get; set; }

    public virtual DbSet<gift_instance> gift_instances { get; set; }

    public virtual DbSet<group> groups { get; set; }

    public virtual DbSet<group_element> group_elements { get; set; }

    public virtual DbSet<gt_copy_dealer_validated> gt_copy_dealer_validateds { get; set; }

    public virtual DbSet<gt_play_session> gt_play_sessions { get; set; }

    public virtual DbSet<gt_play_sessions_by_dealer> gt_play_sessions_by_dealers { get; set; }

    public virtual DbSet<gt_playertracking_movement> gt_playertracking_movements { get; set; }

    public virtual DbSet<gt_seat> gt_seats { get; set; }

    public virtual DbSet<gt_sessions_conciliate> gt_sessions_conciliates { get; set; }

    public virtual DbSet<gui_audit> gui_audits { get; set; }

    public virtual DbSet<gui_filter> gui_filters { get; set; }

    public virtual DbSet<gui_form> gui_forms { get; set; }

    public virtual DbSet<gui_profile_form> gui_profile_forms { get; set; }

    public virtual DbSet<gui_user> gui_users { get; set; }

    public virtual DbSet<gui_user_profile> gui_user_profiles { get; set; }

    public virtual DbSet<gui_user_venue> gui_user_venues { get; set; }

    public virtual DbSet<h_m2d_smh> h_m2d_smhs { get; set; }

    public virtual DbSet<h_m2d_tmh> h_m2d_tmhs { get; set; }

    public virtual DbSet<h_meters_definition> h_meters_definitions { get; set; }

    public virtual DbSet<h_pvh> h_pvhs { get; set; }

    public virtual DbSet<h_t2d_smh> h_t2d_smhs { get; set; }

    public virtual DbSet<h_t2d_tmh> h_t2d_tmhs { get; set; }

    public virtual DbSet<h_w2d_smh> h_w2d_smhs { get; set; }

    public virtual DbSet<h_w2d_tmh> h_w2d_tmhs { get; set; }

    public virtual DbSet<h_x2d_control> h_x2d_controls { get; set; }

    public virtual DbSet<h_y2d_smh> h_y2d_smhs { get; set; }

    public virtual DbSet<h_y2d_tmh> h_y2d_tmhs { get; set; }

    public virtual DbSet<handpay> handpays { get; set; }

    public virtual DbSet<handpays_changes_audit> handpays_changes_audits { get; set; }

    public virtual DbSet<hierarchy_group_element> hierarchy_group_elements { get; set; }

    public virtual DbSet<hierarchy_organization> hierarchy_organizations { get; set; }

    public virtual DbSet<hierarchy_tree> hierarchy_trees { get; set; }

    public virtual DbSet<hierarchy_user> hierarchy_users { get; set; }

    public virtual DbSet<hierarchy_venue> hierarchy_venues { get; set; }

    public virtual DbSet<historical_generated_pattern> historical_generated_patterns { get; set; }

    public virtual DbSet<history_ms_site_dynamic_table> history_ms_site_dynamic_tables { get; set; }

    public virtual DbSet<history_stats_to_work> history_stats_to_works { get; set; }

    public virtual DbSet<hot_seat> hot_seats { get; set; }

    public virtual DbSet<hot_seat_execution> hot_seat_executions { get; set; }

    public virtual DbSet<hot_seat_executions_flag> hot_seat_executions_flags { get; set; }

    public virtual DbSet<hot_seats_flag> hot_seats_flags { get; set; }

    public virtual DbSet<hot_seats_launch_parameter> hot_seats_launch_parameters { get; set; }

    public virtual DbSet<hot_seats_participant> hot_seats_participants { get; set; }

    public virtual DbSet<hourly_liability> hourly_liabilities { get; set; }

    public virtual DbSet<hourly_take_out> hourly_take_outs { get; set; }

    public virtual DbSet<hpc_meter> hpc_meters { get; set; }

    public virtual DbSet<identification_type> identification_types { get; set; }

    public virtual DbSet<ifs_activity> ifs_activities { get; set; }

    public virtual DbSet<imported_file> imported_files { get; set; }

    public virtual DbSet<in_house_event> in_house_events { get; set; }

    public virtual DbSet<install_component> install_components { get; set; }

    public virtual DbSet<intouch_help_page> intouch_help_pages { get; set; }

    public virtual DbSet<intouch_message> intouch_messages { get; set; }

    public virtual DbSet<intouch_record_navigation> intouch_record_navigations { get; set; }

    public virtual DbSet<intouch_session> intouch_sessions { get; set; }

    public virtual DbSet<intouch_terminal_activity> intouch_terminal_activities { get; set; }

    public virtual DbSet<intouch_web_log> intouch_web_logs { get; set; }

    public virtual DbSet<invalid_play_sessions_to_player_tracking> invalid_play_sessions_to_player_trackings { get; set; }

    public virtual DbSet<jackpot_tax_document_mapper> jackpot_tax_document_mappers { get; set; }

    public virtual DbSet<jackpot_tax_document_mapper_bkp_2022_03> jackpot_tax_document_mapper_bkp_2022_03s { get; set; }

    public virtual DbSet<jackpot_tax_template> jackpot_tax_templates { get; set; }

    public virtual DbSet<jackpots_amount_operation> jackpots_amount_operations { get; set; }

    public virtual DbSet<jackpots_amount_terminal> jackpots_amount_terminals { get; set; }

    public virtual DbSet<jackpots_award> jackpots_awards { get; set; }

    public virtual DbSet<jackpots_award_detail> jackpots_award_details { get; set; }

    public virtual DbSet<jackpots_award_filter> jackpots_award_filters { get; set; }

    public virtual DbSet<jackpots_award_filters_flag> jackpots_award_filters_flags { get; set; }

    public virtual DbSet<jackpots_contribution_meter> jackpots_contribution_meters { get; set; }

    public virtual DbSet<jackpots_group> jackpots_groups { get; set; }

    public virtual DbSet<jackpots_group_detail> jackpots_group_details { get; set; }

    public virtual DbSet<jackpots_happy_hour_prize> jackpots_happy_hour_prizes { get; set; }

    public virtual DbSet<jackpots_last_awarded> jackpots_last_awardeds { get; set; }

    public virtual DbSet<jackpots_meter> jackpots_meters { get; set; }

    public virtual DbSet<jackpots_meters_history> jackpots_meters_histories { get; set; }

    public virtual DbSet<jackpots_setting> jackpots_settings { get; set; }

    public virtual DbSet<jackpots_settings_awarding> jackpots_settings_awardings { get; set; }

    public virtual DbSet<jackpots_settings_contribution> jackpots_settings_contributions { get; set; }

    public virtual DbSet<jackpots_settings_customer_tier> jackpots_settings_customer_tiers { get; set; }

    public virtual DbSet<jackpots_settings_happy_hour> jackpots_settings_happy_hours { get; set; }

    public virtual DbSet<jackpots_settings_prize_sharing> jackpots_settings_prize_sharings { get; set; }

    public virtual DbSet<jackpots_viewer> jackpots_viewers { get; set; }

    public virtual DbSet<jackpots_viewers_related_jackpot> jackpots_viewers_related_jackpots { get; set; }

    public virtual DbSet<jackpots_viewers_related_terminal> jackpots_viewers_related_terminals { get; set; }

    public virtual DbSet<junket> junkets { get; set; }

    public virtual DbSet<junkets_commission> junkets_commissions { get; set; }

    public virtual DbSet<junkets_commissions_movement> junkets_commissions_movements { get; set; }

    public virtual DbSet<junkets_commissions_pending> junkets_commissions_pendings { get; set; }

    public virtual DbSet<junkets_flyer> junkets_flyers { get; set; }

    public virtual DbSet<junkets_flyers_flag> junkets_flyers_flags { get; set; }

    public virtual DbSet<junkets_representative> junkets_representatives { get; set; }

    public virtual DbSet<layout_dashboard> layout_dashboards { get; set; }

    public virtual DbSet<layout_device> layout_devices { get; set; }

    public virtual DbSet<layout_enum> layout_enums { get; set; }

    public virtual DbSet<layout_externallog> layout_externallogs { get; set; }

    public virtual DbSet<layout_floor> layout_floors { get; set; }

    public virtual DbSet<layout_location> layout_locations { get; set; }

    public virtual DbSet<layout_manager_runner_message> layout_manager_runner_messages { get; set; }

    public virtual DbSet<layout_medium> layout_media { get; set; }

    public virtual DbSet<layout_mesh> layout_meshes { get; set; }

    public virtual DbSet<layout_mobile_application_version> layout_mobile_application_versions { get; set; }

    public virtual DbSet<layout_notification> layout_notifications { get; set; }

    public virtual DbSet<layout_object> layout_objects { get; set; }

    public virtual DbSet<layout_object_location> layout_object_locations { get; set; }

    public virtual DbSet<layout_parameter> layout_parameters { get; set; }

    public virtual DbSet<layout_permitted_alarm> layout_permitted_alarms { get; set; }

    public virtual DbSet<layout_range> layout_ranges { get; set; }

    public virtual DbSet<layout_ranges_legend> layout_ranges_legends { get; set; }

    public virtual DbSet<layout_recording> layout_recordings { get; set; }

    public virtual DbSet<layout_resource> layout_resources { get; set; }

    public virtual DbSet<layout_runners_position> layout_runners_positions { get; set; }

    public virtual DbSet<layout_site_alarm> layout_site_alarms { get; set; }

    public virtual DbSet<layout_site_task> layout_site_tasks { get; set; }

    public virtual DbSet<layout_site_task_derivation> layout_site_task_derivations { get; set; }

    public virtual DbSet<layout_users_configuration> layout_users_configurations { get; set; }

    public virtual DbSet<layout_users_custom_filter> layout_users_custom_filters { get; set; }

    public virtual DbSet<layout_view> layout_views { get; set; }

    public virtual DbSet<layout_weather_diary> layout_weather_diaries { get; set; }

    public virtual DbSet<lcd_functionality> lcd_functionalities { get; set; }

    public virtual DbSet<lcd_image> lcd_images { get; set; }

    public virtual DbSet<lcd_message> lcd_messages { get; set; }

    public virtual DbSet<lcd_nls_resource> lcd_nls_resources { get; set; }

    public virtual DbSet<lcd_package> lcd_packages { get; set; }

    public virtual DbSet<licence> licences { get; set; }

    public virtual DbSet<live_operation> live_operations { get; set; }

    public virtual DbSet<live_operations_last_processed> live_operations_last_processeds { get; set; }

    public virtual DbSet<live_operations_session> live_operations_sessions { get; set; }

    public virtual DbSet<lotery_hp_mark> lotery_hp_marks { get; set; }

    public virtual DbSet<machine_denom_stats_per_hour> machine_denom_stats_per_hours { get; set; }

    public virtual DbSet<machine_meter> machine_meters { get; set; }

    public virtual DbSet<machine_stats_per_hour> machine_stats_per_hours { get; set; }

    public virtual DbSet<machine_weight> machine_weights { get; set; }

    public virtual DbSet<machine_weights_machine> machine_weights_machines { get; set; }

    public virtual DbSet<mailing_instance> mailing_instances { get; set; }

    public virtual DbSet<mailing_programming> mailing_programmings { get; set; }

    public virtual DbSet<major_prizes_to_generate> major_prizes_to_generates { get; set; }

    public virtual DbSet<mapp_image> mapp_images { get; set; }

    public virtual DbSet<mapp_section_schema> mapp_section_schemas { get; set; }

    public virtual DbSet<mb_movement> mb_movements { get; set; }

    public virtual DbSet<meter> meters { get; set; }

    public virtual DbSet<mobibank_area> mobibank_areas { get; set; }

    public virtual DbSet<mobibank_device> mobibank_devices { get; set; }

    public virtual DbSet<mobibank_device_bank> mobibank_device_banks { get; set; }

    public virtual DbSet<mobibank_request> mobibank_requests { get; set; }

    public virtual DbSet<mobibank_request_status> mobibank_request_statuses { get; set; }

    public virtual DbSet<mobibank_request_status_expired_reason> mobibank_request_status_expired_reasons { get; set; }

    public virtual DbSet<mobile_bank> mobile_banks { get; set; }

    public virtual DbSet<money_collection> money_collections { get; set; }

    public virtual DbSet<money_collection_detail> money_collection_details { get; set; }

    public virtual DbSet<money_collection_details_tmp> money_collection_details_tmps { get; set; }

    public virtual DbSet<money_collection_meter> money_collection_meters { get; set; }

    public virtual DbSet<money_collection_meters_out> money_collection_meters_outs { get; set; }

    public virtual DbSet<money_collections_add_sub_amount> money_collections_add_sub_amounts { get; set; }

    public virtual DbSet<money_collections_add_sub_amount_detail> money_collections_add_sub_amount_details { get; set; }

    public virtual DbSet<money_collections_grouped> money_collections_groupeds { get; set; }

    public virtual DbSet<money_collections_history> money_collections_histories { get; set; }

    public virtual DbSet<money_meter> money_meters { get; set; }

    public virtual DbSet<monitor_datum> monitor_data { get; set; }

    public virtual DbSet<movement_tracking> movement_trackings { get; set; }

    public virtual DbSet<movement_tracking_type> movement_tracking_types { get; set; }

    public virtual DbSet<ms_pending_account_flag> ms_pending_account_flags { get; set; }

    public virtual DbSet<ms_pending_account_flags_backup> ms_pending_account_flags_backups { get; set; }

    public virtual DbSet<ms_pending_account_movement> ms_pending_account_movements { get; set; }

    public virtual DbSet<ms_pending_account_operation> ms_pending_account_operations { get; set; }

    public virtual DbSet<ms_pending_game_play_session> ms_pending_game_play_sessions { get; set; }

    public virtual DbSet<ms_pending_task68_work_datum> ms_pending_task68_work_data { get; set; }

    public virtual DbSet<ms_site_pending_account> ms_site_pending_accounts { get; set; }

    public virtual DbSet<ms_site_pending_account_document> ms_site_pending_account_documents { get; set; }

    public virtual DbSet<ms_site_pending_account_movement> ms_site_pending_account_movements { get; set; }

    public virtual DbSet<ms_site_pending_account_promotion> ms_site_pending_account_promotions { get; set; }

    public virtual DbSet<ms_site_pending_customer> ms_site_pending_customers { get; set; }

    public virtual DbSet<ms_site_pending_customer_record_detail> ms_site_pending_customer_record_details { get; set; }

    public virtual DbSet<ms_site_pending_last_activity> ms_site_pending_last_activities { get; set; }

    public virtual DbSet<ms_site_pending_merge_customers_balance> ms_site_pending_merge_customers_balances { get; set; }

    public virtual DbSet<ms_site_synchronize_account> ms_site_synchronize_accounts { get; set; }

    public virtual DbSet<ms_site_task> ms_site_tasks { get; set; }

    public virtual DbSet<multisite_request> multisite_requests { get; set; }

    public virtual DbSet<nls_app_language> nls_app_languages { get; set; }

    public virtual DbSet<nls_value> nls_values { get; set; }

    public virtual DbSet<note_counter> note_counters { get; set; }

    public virtual DbSet<notice> notices { get; set; }

    public virtual DbSet<notice_account_movement> notice_account_movements { get; set; }

    public virtual DbSet<notice_group> notice_groups { get; set; }

    public virtual DbSet<object_container> object_containers { get; set; }

    public virtual DbSet<occupancy_sensor> occupancy_sensors { get; set; }

    public virtual DbSet<occupation> occupations { get; set; }

    public virtual DbSet<ocl_accounts_transactions_wigo> ocl_accounts_transactions_wigos { get; set; }

    public virtual DbSet<ocl_linkedexternalaccount> ocl_linkedexternalaccounts { get; set; }

    public virtual DbSet<online_player_tracking> online_player_trackings { get; set; }

    public virtual DbSet<operation_voucher_parameter> operation_voucher_parameters { get; set; }

    public virtual DbSet<operations_after_hour> operations_after_hours { get; set; }

    public virtual DbSet<operations_schedule> operations_schedules { get; set; }

    public virtual DbSet<operations_schedule_status> operations_schedule_statuses { get; set; }

    public virtual DbSet<patron_summary_history> patron_summary_histories { get; set; }

    public virtual DbSet<pattern> patterns { get; set; }

    public virtual DbSet<patterns_information> patterns_informations { get; set; }

    public virtual DbSet<pcd_meters_translation> pcd_meters_translations { get; set; }

    public virtual DbSet<pending_play_sessions_to_player_tracking> pending_play_sessions_to_player_trackings { get; set; }

    public virtual DbSet<pinpad_cashier_terminal> pinpad_cashier_terminals { get; set; }

    public virtual DbSet<pinpad_transaction> pinpad_transactions { get; set; }

    public virtual DbSet<pinpad_transactions_reconciliation> pinpad_transactions_reconciliations { get; set; }

    public virtual DbSet<play> plays { get; set; }

    public virtual DbSet<play_safe_similar_terminal> play_safe_similar_terminals { get; set; }

    public virtual DbSet<play_safe_terminal_notification> play_safe_terminal_notifications { get; set; }

    public virtual DbSet<play_safe_terminal_pending> play_safe_terminal_pendings { get; set; }

    public virtual DbSet<play_safe_terminal_processed_group> play_safe_terminal_processed_groups { get; set; }

    public virtual DbSet<play_safe_terminal_status> play_safe_terminal_statuses { get; set; }

    public virtual DbSet<play_session> play_sessions { get; set; }

    public virtual DbSet<play_session_cashout> play_session_cashouts { get; set; }

    public virtual DbSet<play_session_interval> play_session_intervals { get; set; }

    public virtual DbSet<play_sessions_assignments_history> play_sessions_assignments_histories { get; set; }

    public virtual DbSet<play_sessions_theo_win_to_historify> play_sessions_theo_win_to_historifies { get; set; }

    public virtual DbSet<player_level_icon> player_level_icons { get; set; }

    public virtual DbSet<player_notification> player_notifications { get; set; }

    public virtual DbSet<player_notification_configuration> player_notification_configurations { get; set; }

    public virtual DbSet<player_notification_flag> player_notification_flags { get; set; }

    public virtual DbSet<players_online> players_onlines { get; set; }

    public virtual DbSet<points_to_credit> points_to_credits { get; set; }

    public virtual DbSet<prize_tax_form_process> prize_tax_form_processes { get; set; }

    public virtual DbSet<prize_tax_form_result> prize_tax_form_results { get; set; }

    public virtual DbSet<progressife> progressives { get; set; }

    public virtual DbSet<progressives_level> progressives_levels { get; set; }

    public virtual DbSet<progressives_provision> progressives_provisions { get; set; }

    public virtual DbSet<progressives_provisions_level> progressives_provisions_levels { get; set; }

    public virtual DbSet<progressives_provisions_terminal> progressives_provisions_terminals { get; set; }

    public virtual DbSet<promogame> promogames { get; set; }

    public virtual DbSet<promogame_type_play_session> promogame_type_play_sessions { get; set; }

    public virtual DbSet<promotion> promotions { get; set; }

    public virtual DbSet<promotion_account_pending> promotion_account_pendings { get; set; }

    public virtual DbSet<promotion_account_restriction> promotion_account_restrictions { get; set; }

    public virtual DbSet<promotion_category> promotion_categories { get; set; }

    public virtual DbSet<promotion_date_range_period_of_study> promotion_date_range_period_of_studies { get; set; }

    public virtual DbSet<promotion_flag> promotion_flags { get; set; }

    public virtual DbSet<promotion_period_of_study_notification> promotion_period_of_study_notifications { get; set; }

    public virtual DbSet<promotion_period_of_study_processed> promotion_period_of_study_processeds { get; set; }

    public virtual DbSet<provider> providers { get; set; }

    public virtual DbSet<provider_model> provider_models { get; set; }

    public virtual DbSet<providers_bck> providers_bcks { get; set; }

    public virtual DbSet<providers_game> providers_games { get; set; }

    public virtual DbSet<psa_client_daily_report> psa_client_daily_reports { get; set; }

    public virtual DbSet<recent_account_alarm> recent_account_alarms { get; set; }

    public virtual DbSet<report> reports { get; set; }

    public virtual DbSet<report_tool_config> report_tool_configs { get; set; }

    public virtual DbSet<reporting_field> reporting_fields { get; set; }

    public virtual DbSet<reporting_fields_concept> reporting_fields_concepts { get; set; }

    public virtual DbSet<reserved_terminal_configuration> reserved_terminal_configurations { get; set; }

    public virtual DbSet<reserved_terminal_transaction> reserved_terminal_transactions { get; set; }

    public virtual DbSet<reserved_terminals_by_tier> reserved_terminals_by_tiers { get; set; }

    public virtual DbSet<reserved_terminals_by_tier_configuration> reserved_terminals_by_tier_configurations { get; set; }

    public virtual DbSet<safe_keeping_account> safe_keeping_accounts { get; set; }

    public virtual DbSet<safe_keeping_operation> safe_keeping_operations { get; set; }

    public virtual DbSet<sales_interface> sales_interfaces { get; set; }

    public virtual DbSet<sales_per_hour> sales_per_hours { get; set; }

    public virtual DbSet<sas_meters_adjustment> sas_meters_adjustments { get; set; }

    public virtual DbSet<sas_meters_catalog> sas_meters_catalogs { get; set; }

    public virtual DbSet<sas_meters_catalog_per_group> sas_meters_catalog_per_groups { get; set; }

    public virtual DbSet<sas_meters_catalogsas_meters_group> sas_meters_catalogsas_meters_groups { get; set; }

    public virtual DbSet<sas_meters_group> sas_meters_groups { get; set; }

    public virtual DbSet<sclm_activity> sclm_activities { get; set; }

    public virtual DbSet<sending_instance> sending_instances { get; set; }

    public virtual DbSet<sequence> sequences { get; set; }

    public virtual DbSet<service> services { get; set; }

    public virtual DbSet<service_component> service_components { get; set; }

    public virtual DbSet<service_internet_connection> service_internet_connections { get; set; }

    public virtual DbSet<sessions_pending_close> sessions_pending_closes { get; set; }

    public virtual DbSet<settlement> settlements { get; set; }

    public virtual DbSet<settlements_collection> settlements_collections { get; set; }

    public virtual DbSet<site> sites { get; set; }

    public virtual DbSet<site1> sites1 { get; set; }

    public virtual DbSet<site_jackpot_instance> site_jackpot_instances { get; set; }

    public virtual DbSet<site_jackpot_parameter> site_jackpot_parameters { get; set; }

    public virtual DbSet<site_service> site_services { get; set; }

    public virtual DbSet<smib_communication_type> smib_communication_types { get; set; }

    public virtual DbSet<smib_configuration> smib_configurations { get; set; }

    public virtual DbSet<soft_count> soft_counts { get; set; }

    public virtual DbSet<software_validation> software_validations { get; set; }

    public virtual DbSet<sound> sounds { get; set; }

    public virtual DbSet<sph_control> sph_controls { get; set; }

    public virtual DbSet<stacker> stackers { get; set; }

    public virtual DbSet<tax_by_country> tax_by_countries { get; set; }

    public virtual DbSet<tax_report_bill_in> tax_report_bill_ins { get; set; }

    public virtual DbSet<terminal> terminals { get; set; }

    public virtual DbSet<terminal_attribute> terminal_attributes { get; set; }

    public virtual DbSet<terminal_attribute_value> terminal_attribute_values { get; set; }

    public virtual DbSet<terminal_communication_type> terminal_communication_types { get; set; }

    public virtual DbSet<terminal_currency> terminal_currencies { get; set; }

    public virtual DbSet<terminal_currency_detail> terminal_currency_details { get; set; }

    public virtual DbSet<terminal_draws_recharge> terminal_draws_recharges { get; set; }

    public virtual DbSet<terminal_error_code> terminal_error_codes { get; set; }

    public virtual DbSet<terminal_game_translation> terminal_game_translations { get; set; }

    public virtual DbSet<terminal_group> terminal_groups { get; set; }

    public virtual DbSet<terminal_last_msg_type> terminal_last_msg_types { get; set; }

    public virtual DbSet<terminal_meter_delta_description> terminal_meter_delta_descriptions { get; set; }

    public virtual DbSet<terminal_meter_deltum> terminal_meter_delta { get; set; }

    public virtual DbSet<terminal_money> terminal_moneys { get; set; }

    public virtual DbSet<terminal_sas_meter> terminal_sas_meters { get; set; }

    public virtual DbSet<terminal_sas_meters_by_denomination_history> terminal_sas_meters_by_denomination_histories { get; set; }

    public virtual DbSet<terminal_sas_meters_history> terminal_sas_meters_histories { get; set; }

    public virtual DbSet<terminal_sas_meters_history_false_rollover> terminal_sas_meters_history_false_rollovers { get; set; }

    public virtual DbSet<terminal_sas_meters_history_info> terminal_sas_meters_history_infos { get; set; }

    public virtual DbSet<terminal_sas_meters_history_pending> terminal_sas_meters_history_pendings { get; set; }

    public virtual DbSet<terminal_sas_meters_msg_configuration> terminal_sas_meters_msg_configurations { get; set; }

    public virtual DbSet<terminal_sas_meters_msg_history> terminal_sas_meters_msg_histories { get; set; }

    public virtual DbSet<terminal_sas_meters_msg_last_configuration> terminal_sas_meters_msg_last_configurations { get; set; }

    public virtual DbSet<terminal_sas_meters_msg_value> terminal_sas_meters_msg_values { get; set; }

    public virtual DbSet<terminal_sas_meters_pre_history> terminal_sas_meters_pre_histories { get; set; }

    public virtual DbSet<terminal_sas_meters_to_historify> terminal_sas_meters_to_historifies { get; set; }

    public virtual DbSet<terminal_setting> terminal_settings { get; set; }

    public virtual DbSet<terminal_software_version> terminal_software_versions { get; set; }

    public virtual DbSet<terminal_status> terminal_statuses { get; set; }

    public virtual DbSet<terminal_type> terminal_types { get; set; }

    public virtual DbSet<terminals_3g> terminals_3gs { get; set; }

    public virtual DbSet<terminals_connected> terminals_connecteds { get; set; }

    public virtual DbSet<terminals_pending> terminals_pendings { get; set; }

    public virtual DbSet<terminals_time_disconnected> terminals_time_disconnecteds { get; set; }

    public virtual DbSet<threshold_operation> threshold_operations { get; set; }

    public virtual DbSet<ticket> tickets { get; set; }

    public virtual DbSet<ticket_exception_audit> ticket_exception_audits { get; set; }

    public virtual DbSet<tickets_audit_status_change> tickets_audit_status_changes { get; set; }

    public virtual DbSet<tickets_discarded> tickets_discardeds { get; set; }

    public virtual DbSet<tito_task> tito_tasks { get; set; }

    public virtual DbSet<today_visit> today_visits { get; set; }

    public virtual DbSet<tpv_recharge> tpv_recharges { get; set; }

    public virtual DbSet<user_collection_status> user_collection_statuses { get; set; }

    public virtual DbSet<venue> venues { get; set; }

    public virtual DbSet<venue_group> venue_groups { get; set; }

    public virtual DbSet<venue_operator> venue_operators { get; set; }

    public virtual DbSet<venue_status> venue_statuses { get; set; }

    public virtual DbSet<venue_type> venue_types { get; set; }

    public virtual DbSet<wam_audit> wam_audits { get; set; }

    public virtual DbSet<wc2_message> wc2_messages { get; set; }

    public virtual DbSet<wc2_session> wc2_sessions { get; set; }

    public virtual DbSet<wc2_transaction> wc2_transactions { get; set; }

    public virtual DbSet<wcp_command> wcp_commands { get; set; }

    public virtual DbSet<wcp_message> wcp_messages { get; set; }

    public virtual DbSet<wcp_service> wcp_services { get; set; }

    public virtual DbSet<wcp_services_to_cj_queue> wcp_services_to_cj_queues { get; set; }

    public virtual DbSet<wcp_session> wcp_sessions { get; set; }

    public virtual DbSet<wcp_transaction> wcp_transactions { get; set; }

    public virtual DbSet<whitelist_ipv4_address> whitelist_ipv4_addresses { get; set; }

    public virtual DbSet<win_loss_statement> win_loss_statements { get; set; }

    public virtual DbSet<win_loss_statement_detail> win_loss_statement_details { get; set; }

    public virtual DbSet<winstats_cashier_day> winstats_cashier_days { get; set; }

    public virtual DbSet<winstats_cashier_month> winstats_cashier_months { get; set; }

    public virtual DbSet<winstats_summary_day> winstats_summary_days { get; set; }

    public virtual DbSet<winstats_summary_month> winstats_summary_months { get; set; }

    public virtual DbSet<winstats_summary_status_history> winstats_summary_status_histories { get; set; }

    public virtual DbSet<wkt_ad> wkt_ads { get; set; }

    public virtual DbSet<wkt_ad_step> wkt_ad_steps { get; set; }

    public virtual DbSet<wkt_ad_step_detail> wkt_ad_step_details { get; set; }

    public virtual DbSet<wkt_functionality> wkt_functionalities { get; set; }

    public virtual DbSet<wkt_image> wkt_images { get; set; }

    public virtual DbSet<wkt_player_info_field> wkt_player_info_fields { get; set; }

    public virtual DbSet<wkt_resource> wkt_resources { get; set; }

    public virtual DbSet<wrkp_kiosk_status> wrkp_kiosk_statuses { get; set; }

    public virtual DbSet<wrkp_session> wrkp_sessions { get; set; }

    public virtual DbSet<wrkp_session_movement> wrkp_session_movements { get; set; }

    public virtual DbSet<wsp_authorized_vendor> wsp_authorized_vendors { get; set; }

    public virtual DbSet<wsp_player_recharge> wsp_player_recharges { get; set; }

    public virtual DbSet<wsp_player_spent_by_day> wsp_player_spent_by_days { get; set; }

    public virtual DbSet<wwp_status> wwp_statuses { get; set; }

    public virtual DbSet<wxp_001_message> wxp_001_messages { get; set; }

    public virtual DbSet<wxp_002_message> wxp_002_messages { get; set; }

    public virtual DbSet<wxp_parameter> wxp_parameters { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=.;Database=wgdb_000_keops;User Id=sa;Password=147896321;Trusted_Connection=false; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AFIP_DETALLE_TERMINALE>(entity =>
        {
            entity.HasKey(e => new { e.adt_fechaJornada, e.adt_IdMaquina, e.adt_secuencia }).HasName("PK_DETALLE_TERMINALES");

            entity.Property(e => e.adt_created_date).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<BONUSING_GAMES_LIMIT>(entity =>
        {
            entity.Property(e => e.BGL_UPDATE_DATETIME).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Card_Generation>(entity =>
        {
            entity.Property(e => e.cg_site_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<DELETE_BUFFER_HandPays_TEMP>(entity =>
        {
            entity.Property(e => e.HP_TIMESTAMP)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<MIGRATION_ACCOUNT>(entity =>
        {
            entity.Property(e => e.SOURCE_ACCOUNT_ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<Resultado_fragment>(entity =>
        {
            entity.Property(e => e.Clust).UseCollation("Latin1_General_CI_AS_KS_WS");
        });

        modelBuilder.Entity<TABLESFRAGMENT>(entity =>
        {
            entity.Property(e => e.Clust).UseCollation("Latin1_General_CI_AS_KS_WS");
        });

        modelBuilder.Entity<TMP_TERMINALS_TO_BASE_NAME>(entity =>
        {
            entity.Property(e => e.te_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<account>(entity =>
        {
            entity.HasIndex(e => e.ac_type, "IX_ac_type").HasFilter("([ac_type] IN ((6), (7)))");

            entity.HasIndex(e => e.ac_track_data, "IX_track_data")
                .IsUnique()
                .HasFilter("([ac_track_data] IS NOT NULL)");

            entity.Property(e => e.ac_account_id).ValueGeneratedNever();
            entity.Property(e => e.ac_bad_address1).HasDefaultValue(0);
            entity.Property(e => e.ac_bad_address2).HasDefaultValue(0);
            entity.Property(e => e.ac_bad_address3).HasDefaultValue(0);
            entity.Property(e => e.ac_beneficiary_id1_type).HasDefaultValue(1);
            entity.Property(e => e.ac_beneficiary_id2_type).HasDefaultValue(2);
            entity.Property(e => e.ac_created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ac_holder_id1_type).HasDefaultValue(1);
            entity.Property(e => e.ac_holder_id2_type).HasDefaultValue(2);
            entity.Property(e => e.ac_holder_level_entered).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ac_holder_level_notify).HasDefaultValue(0);
            entity.Property(e => e.ac_in_session_cash_in).HasDefaultValue(0m);
            entity.Property(e => e.ac_in_session_promo_ticket_nr_in).HasDefaultValue(0m);
            entity.Property(e => e.ac_in_session_promo_ticket_re_in).HasDefaultValue(0m);
            entity.Property(e => e.ac_last_activity).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ac_last_update_in_local_time).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ac_last_update_in_utc_time).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.ac_no_mail1).HasDefaultValue(0);
            entity.Property(e => e.ac_no_mail2).HasDefaultValue(0);
            entity.Property(e => e.ac_no_mail3).HasDefaultValue(0);
            entity.Property(e => e.ac_nr_won_lock).HasDefaultValue(0m);
            entity.Property(e => e.ac_points).HasDefaultValue(0m);
            entity.Property(e => e.ac_points_status).HasDefaultValue(0);
            entity.Property(e => e.ac_preferred_method).HasDefaultValue(0);
            entity.Property(e => e.ac_promo_creation).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ac_promo_expiration).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ac_show_holder_name).HasDefaultValue(true);
            entity.Property(e => e.ac_tax_form_expiration_date).HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");
            entity.Property(e => e.ac_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.ac_user_type).HasDefaultValue(0);
        });

        modelBuilder.Entity<account_document>(entity =>
        {
            entity.Property(e => e.ad_account_id).ValueGeneratedNever();
            entity.Property(e => e.ad_created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ad_modified).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<account_flag>(entity =>
        {
            entity.Property(e => e.af_unique_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<account_major_prize>(entity =>
        {
            entity.Property(e => e.amp_operation_id).ValueGeneratedNever();
            entity.Property(e => e.amp_datetime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.amp_unauthorized).HasDefaultValue(false);
        });

        modelBuilder.Entity<account_movement>(entity =>
        {
            entity.HasKey(e => e.am_movement_id).HasName("PK_movements");

            entity.Property(e => e.am_movement_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<account_movements_by_time>(entity =>
        {
            entity.HasKey(e => new { e.ambt_cashier_id, e.ambt_account_id, e.ambt_operation_id, e.ambt_datetime }).HasName("PK__account___5756184666C3C6D3");
        });

        modelBuilder.Entity<account_operation>(entity =>
        {
            entity.Property(e => e.ao_operation_id).ValueGeneratedNever();
            entity.Property(e => e.ao_datetime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ao_spent_used).HasDefaultValue(0m);
        });

        modelBuilder.Entity<account_payment_order>(entity =>
        {
            entity.HasKey(e => e.apo_operation_id).HasName("PK_account_payment_order");

            entity.Property(e => e.apo_operation_id).ValueGeneratedNever();
            entity.Property(e => e.apo_datetime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<account_photo>(entity =>
        {
            entity.Property(e => e.aph_account_id).ValueGeneratedNever();
            entity.Property(e => e.aph_last_update).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<account_points_cache>(entity =>
        {
            entity.Property(e => e.apc_account_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<account_points_expired_list>(entity =>
        {
            entity.Property(e => e.apel_account_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<account_promotion>(entity =>
        {
            entity.Property(e => e.acp_unique_id).ValueGeneratedNever();
            entity.Property(e => e.acp_converted_amount).HasDefaultValue(0m);
            entity.Property(e => e.acp_created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.acp_draw_price).HasDefaultValueSql("('0')");
            entity.Property(e => e.acp_import_filename).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.acp_lock_average_bet).HasDefaultValue(0m);
            entity.Property(e => e.acp_lock_balance_amount).HasDefaultValue(0m);
            entity.Property(e => e.acp_lock_balance_factor).HasDefaultValue(0);
            entity.Property(e => e.acp_lock_coin_in_amount).HasDefaultValue(0m);
            entity.Property(e => e.acp_lock_coin_in_factor).HasDefaultValue(0);
            entity.Property(e => e.acp_lock_max_payable_amount).HasDefaultValue(0m);
            entity.Property(e => e.acp_lock_max_payable_factor).HasDefaultValue(0m);
            entity.Property(e => e.acp_lock_min_payable_amount).HasDefaultValue(0m);
            entity.Property(e => e.acp_lock_plays).HasDefaultValue(0);
            entity.Property(e => e.acp_min_cash_in_reward).HasDefaultValue(0m);
            entity.Property(e => e.acp_min_spent).HasDefaultValue(0m);
            entity.Property(e => e.acp_min_spent_reward).HasDefaultValue(0m);
            entity.Property(e => e.acp_ms_id).HasDefaultValue(-1L);
            entity.Property(e => e.acp_ms_promo_id).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.acp_num_tokens).HasDefaultValue(0);
            entity.Property(e => e.acp_num_used_tokens).HasDefaultValue(0);
            entity.Property(e => e.acp_pyramid_prize).HasDefaultValueSql("('0')");
            entity.Property(e => e.acp_redeemable_cost).HasDefaultValue(0m);
            entity.Property(e => e.acp_redeemable_played).HasDefaultValue(0m);
            entity.Property(e => e.acp_site_redeemed).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.acp_token_reward).HasDefaultValue(0m);
            entity.Property(e => e.acp_total_prize).HasDefaultValueSql("('0')");
            entity.Property(e => e.acp_updated).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<account_promotion_track>(entity =>
        {
            entity.HasIndex(e => new { e.apt_pending_reward_flag, e.apt_account_id, e.apt_promo_id }, "IDX_apt_pending_reward_flag")
                .IsUnique()
                .IsDescending(true, false, false)
                .HasFilter("([apt_pending_reward_flag]=(1))");
        });

        modelBuilder.Entity<afip_log>(entity =>
        {
            entity.HasKey(e => e.afl_id).HasName("PK_AFIP_LOG");

            entity.Property(e => e.afl_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<alarm>(entity =>
        {
            entity.Property(e => e.al_alarm_id).ValueGeneratedNever();
            entity.Property(e => e.al_reported).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.al_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<alarm_catalog_per_category>(entity =>
        {
            entity.Property(e => e.alcc_datetime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<alarm_category>(entity =>
        {
            entity.HasKey(e => new { e.alc_category_id, e.alc_language_id }).HasName("PK_category");
        });

        modelBuilder.Entity<alarm_group>(entity =>
        {
            entity.HasKey(e => new { e.alg_alarm_group_id, e.alg_language_id }).HasName("PK_alarm_group");
        });

        modelBuilder.Entity<alesis_terminal>(entity =>
        {
            entity.Property(e => e.at_terminal_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<aml_daily>(entity =>
        {
            entity.Property(e => e.amd_track_data).HasDefaultValue("");
        });

        modelBuilder.Entity<aml_monthly>(entity =>
        {
            entity.Property(e => e.amm_track_data).HasDefaultValue("");
        });

        modelBuilder.Entity<application>(entity =>
        {
            entity.HasIndex(e => new { e.app_name, e.app_alias }, "IX_app_name_alias")
                .IsUnique()
                .HasFilter("([app_alias] IS NOT NULL)");

            entity.Property(e => e.app_id).ValueGeneratedNever();
            entity.Property(e => e.app_net_installed).HasDefaultValue("");
            entity.Property(e => e.app_os_installed).HasDefaultValue("");
        });

        modelBuilder.Entity<area>(entity =>
        {
            entity.Property(e => e.ar_area_id).ValueGeneratedNever();
            entity.Property(e => e.ar_external_id).HasDefaultValue("0");
            entity.Property(e => e.ar_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<audit_3g>(entity =>
        {
            entity.Property(e => e.a3gs_execution).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<authorization_audit>(entity =>
        {
            entity.Property(e => e.aa_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<authorization_limit>(entity =>
        {
            entity.Property(e => e.al_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<auto_print_cash_out_receipt_report>(entity =>
        {
            entity.HasKey(e => e.apcurr_voucher_id).HasName("PK_apcurr_voucher_id");

            entity.Property(e => e.apcurr_voucher_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<auto_print_pending_generation_voucher>(entity =>
        {
            entity.HasKey(e => new { e.appgv_session_id, e.appgv_type }).HasName("PK_appgv_session_id");
        });

        modelBuilder.Entity<auto_print_pending_print_voucher>(entity =>
        {
            entity.HasKey(e => new { e.apppv_voucher_id, e.apppv_type }).HasName("PK_apppv_voucher_id");
        });

        modelBuilder.Entity<bank>(entity =>
        {
            entity.Property(e => e.bk_bank_id).ValueGeneratedNever();
            entity.Property(e => e.bk_external_id).HasDefaultValue("0");
            entity.Property(e => e.bk_shape_code).IsFixedLength();
            entity.Property(e => e.bk_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<bank_account>(entity =>
        {
            entity.Property(e => e.ba_account_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<bank_transaction>(entity =>
        {
            entity.Property(e => e.bt_operation_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<blacklist_bind>(entity =>
        {
            entity.Property(e => e.bb_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<blacklist_file_imported>(entity =>
        {
            entity.HasIndex(e => new { e.blkf_name, e.blkf_lastname_1, e.blkf_birth_date, e.blkf_id_type }, "IX_blacklist_file_imported_match").IsClustered();

            entity.Property(e => e.blkf_id_type).HasDefaultValue(-1);
        });

        modelBuilder.Entity<blacklist_file_imported_type>(entity =>
        {
            entity.HasKey(e => e.bklt_id_type).HasName("PK__blacklis__DEE9EDAE505CEC51");

            entity.Property(e => e.bklt_id_type).ValueGeneratedNever();
        });

        modelBuilder.Entity<blacklist_internal_block_list>(entity =>
        {
            entity.Property(e => e.bkl_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<blacklist_positive_case>(entity =>
        {
            entity.Property(e => e.bpc_authorized).HasDefaultValue(false);
        });

        modelBuilder.Entity<blacklist_rule>(entity =>
        {
            entity.Property(e => e.br_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<blacklist_rules_bind>(entity =>
        {
            entity.Property(e => e.brb_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<blacklist_rules_description>(entity =>
        {
            entity.Property(e => e.brd_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<bonuse>(entity =>
        {
            entity.Property(e => e.bns_bonus_id).ValueGeneratedNever();
            entity.Property(e => e.bns_inserted).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.bns_transfer_status_changed).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<bonusing_game>(entity =>
        {
            entity.Property(e => e.bg_bonusing_game_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<bucket>(entity =>
        {
            entity.Property(e => e.bu_bucket_id).ValueGeneratedNever();
            entity.Property(e => e.bu_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<bucket_limits_profile>(entity =>
        {
            entity.HasKey(e => e.blp_id).HasName("PK__bucket_l__D56E1A5A0EB45539");

            entity.Property(e => e.blp_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<buckets_multiplier_schedule>(entity =>
        {
            entity.Property(e => e.bm_bucket_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<buckets_multiplier_to_apply>(entity =>
        {
            entity.HasKey(e => new { e.bma_Bucket_ID, e.bma_Terminal_ID, e.bma_Level }).IsClustered(false);
        });

        modelBuilder.Entity<buffer_terminals_time_disconnected>(entity =>
        {
            entity.HasKey(e => new { e.bttd_site_id, e.bttd_terminal_id, e.bttd_working_day }).HasName("PK_bttd_id");
        });

        modelBuilder.Entity<c2_jackpot_counter>(entity =>
        {
            entity.Property(e => e.c2jc_index).ValueGeneratedNever();
        });

        modelBuilder.Entity<c2_jackpot_instance>(entity =>
        {
            entity.Property(e => e.c2ji_index).ValueGeneratedNever();
            entity.Property(e => e.c2ji_show_on_winup).HasDefaultValue(true);
            entity.Property(e => e.c2ji_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<c2_jackpot_parameter>(entity =>
        {
            entity.Property(e => e.c2jp_animation_interval).HasDefaultValue(15);
            entity.Property(e => e.c2jp_awarding_days).HasDefaultValue(127);
            entity.Property(e => e.c2jp_awarding_end).HasDefaultValue(86399);
            entity.Property(e => e.c2jp_block_interval).HasDefaultValue(300);
            entity.Property(e => e.c2jp_recent_interval).HasDefaultValue(3600);
            entity.Property(e => e.c2jp_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<c2_winning_pattern>(entity =>
        {
            entity.Property(e => e.w2p_pattern_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<c2go_card>(entity =>
        {
            entity.HasKey(e => e.c2g_card_trackdata).HasName("c2g_card_trackdata_key");
        });

        modelBuilder.Entity<cage_cashier_movement_relation>(entity =>
        {
            entity.HasKey(e => new { e.cgm_movement_id, e.cm_movement_id }).HasName("PK_CAGE_CASHIER_MOVEMENT_RELATION");
        });

        modelBuilder.Entity<cage_concept>(entity =>
        {
            entity.Property(e => e.cc_concept_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<cage_currency>(entity =>
        {
            entity.Property(e => e.cgc_cage_visible).HasDefaultValue(true);
        });

        modelBuilder.Entity<cage_pending_movement>(entity =>
        {
            entity.HasKey(e => e.cpm_movement_id).HasName("PK_CAGE_PENDING_MOVEMENT");

            entity.Property(e => e.cpm_movement_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<cage_source_target>(entity =>
        {
            entity.HasKey(e => e.cst_source_target_id).HasName("PK_CAGE_SOURCE_TARGET");

            entity.Property(e => e.cst_source_target_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<cage_source_target_concept>(entity =>
        {
            entity.Property(e => e.cstc_price_factor).HasDefaultValue(10m);
        });

        modelBuilder.Entity<card>(entity =>
        {
            entity.Property(e => e.ca_pin).IsFixedLength();
            entity.Property(e => e.ca_refundable_deposit).HasDefaultValue(0m);
        });

        modelBuilder.Entity<cashier_movements_grouped_by_hour>(entity =>
        {
            entity.HasKey(e => new { e.CM_DATE, e.CM_TYPE, e.CM_SUB_TYPE, e.CM_CURRENCY_ISO_CODE, e.CM_CAGE_CURRENCY_TYPE, e.CM_CURRENCY_DENOMINATION }).HasName("PK_CASHIER_MOVEMENTS_GROUPED_BY_HOUR");

            entity.HasIndex(e => e.cm_timestamp, "IX_cmgh_timestamp")
                .IsUnique()
                .HasFilter("([cm_timestamp] IS NOT NULL)");

            entity.Property(e => e.cm_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<cashier_movements_grouped_by_session_id>(entity =>
        {
            entity.HasKey(e => new { e.CM_SESSION_ID, e.CM_TYPE, e.CM_SUB_TYPE, e.CM_CURRENCY_ISO_CODE, e.CM_CAGE_CURRENCY_TYPE, e.CM_CURRENCY_DENOMINATION }).HasName("PK_CASHIER_MOVEMENTS_GROUPED_BY_SESSION_ID");
        });

        modelBuilder.Entity<cashier_movements_pending_history>(entity =>
        {
            entity.HasKey(e => new { e.cmph_movement_id, e.cmph_sub_type }).HasName("pk_cashier_movements_pending_history");
        });

        modelBuilder.Entity<catalog>(entity =>
        {
            entity.Property(e => e.cat_id).ValueGeneratedNever();
            entity.Property(e => e.cat_system_type).HasDefaultValue(0);
        });

        modelBuilder.Entity<catalog_item>(entity =>
        {
            entity.Property(e => e.cai_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<cfdi_register>(entity =>
        {
            entity.Property(e => e.cr_operation_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<chips_sets_chip>(entity =>
        {
            entity.HasKey(e => new { e.csc_chip_id, e.csc_set_id }).HasName("PK_chip_id_set_id");
        });

        modelBuilder.Entity<chips_stock>(entity =>
        {
            entity.HasKey(e => e.chsk_chip_id).HasName("PK_chips_stocks");

            entity.Property(e => e.chsk_chip_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<cj_queue>(entity =>
        {
            entity.Property(e => e.cq_queue_id).ValueGeneratedNever();
            entity.Property(e => e.cq_sequence_number).HasDefaultValue(1);
        });

        modelBuilder.Entity<cj_transaction>(entity =>
        {
            entity.Property(e => e.ctx_status).HasComment("0 - Running, 1 - Finished");
        });

        modelBuilder.Entity<closing_stock>(entity =>
        {
            entity.Property(e => e.cs_cashier_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<country>(entity =>
        {
            entity.Property(e => e.co_language_id).HasDefaultValue(10);
        });

        modelBuilder.Entity<credit_line>(entity =>
        {
            entity.Property(e => e.cl_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<credit_line_movement>(entity =>
        {
            entity.Property(e => e.clm_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<currency_exchange>(entity =>
        {
            entity.Property(e => e.ce_currency_order).HasDefaultValue(0L);
        });

        modelBuilder.Entity<customer>(entity =>
        {
            entity.Property(e => e.cus_customer_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<customer_bucket>(entity =>
        {
            entity.Property(e => e.cbu_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<customer_entrance>(entity =>
        {
            entity.HasIndex(e => e.cue_timestamp, "IX_cue_timestamp")
                .IsUnique()
                .HasFilter("([cue_timestamp] IS NOT NULL)");

            entity.Property(e => e.cue_entrance_datetime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.cue_coupon).IsFixedLength();
            entity.Property(e => e.cue_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<customer_notice>(entity =>
        {
            entity.Property(e => e.cn_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<customer_visit>(entity =>
        {
            entity.Property(e => e.cut_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<customer_visit_egm_stat>(entity =>
        {
            entity.HasIndex(e => e.cve_timestamp, "IX_cve_timestamp")
                .IsUnique()
                .HasFilter("([cve_timestamp] IS NOT NULL)");

            entity.Property(e => e.cve_visit_id).ValueGeneratedNever();
            entity.Property(e => e.cve_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<customer_visit_gt_stat>(entity =>
        {
            entity.HasIndex(e => e.cvgt_timestamp, "IX_cvgt_timestamp")
                .IsUnique()
                .HasFilter("([cvgt_timestamp] IS NOT NULL)");

            entity.Property(e => e.cvgt_visit_id).ValueGeneratedNever();
            entity.Property(e => e.cvgt_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<customers_sum_balance>(entity =>
        {
            entity.Property(e => e.csb_account_id_target).ValueGeneratedNever();
        });

        modelBuilder.Entity<db_user>(entity =>
        {
            entity.Property(e => e.du_password).IsFixedLength();
        });

        modelBuilder.Entity<draw>(entity =>
        {
            entity.Property(e => e.dr_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<drawing_flag>(entity =>
        {
            entity.Property(e => e.df_flag_count_excluded).HasDefaultValueSql("(NULL)");
        });

        modelBuilder.Entity<egm_control_mark>(entity =>
        {
            entity.Property(e => e.ecm_site_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<egm_daily>(entity =>
        {
            entity.Property(e => e.ed_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<egm_meters_by_day>(entity =>
        {
            entity.Property(e => e.emd_user_period_modified).HasDefaultValue(false);
            entity.Property(e => e.emd_user_validated).HasDefaultValue(false);
            entity.Property(e => e.emd_warning).HasDefaultValue(0);
        });

        modelBuilder.Entity<egm_stage_daily>(entity =>
        {
            entity.Property(e => e.esd_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<egm_stage_meters_by_day>(entity =>
        {
            entity.Property(e => e.esmd_mc_0036_increment).HasDefaultValue(0m);
        });

        modelBuilder.Entity<egm_stage_meters_by_period>(entity =>
        {
            entity.Property(e => e.esmp_mc_0036_increment).HasDefaultValue(0m);
        });

        modelBuilder.Entity<elp01_space_request>(entity =>
        {
            entity.Property(e => e.es_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<elp01_voucher>(entity =>
        {
            entity.Property(e => e.ev_datetime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<event_history>(entity =>
        {
            entity.Property(e => e.eh_reported).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.eh_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<financialReport>(entity =>
        {
            entity.Property(e => e.BILL_COLLECTED).HasDefaultValue(0L);
            entity.Property(e => e.BILL_IN).HasDefaultValue(0L);
            entity.Property(e => e.CHANGED_COLUMNS).HasDefaultValue(0);
            entity.Property(e => e.M0).HasDefaultValue(0L);
            entity.Property(e => e.M1).HasDefaultValue(0L);
            entity.Property(e => e.M10).HasDefaultValue(0L);
            entity.Property(e => e.M11).HasDefaultValue(0L);
            entity.Property(e => e.M128).HasDefaultValue(0L);
            entity.Property(e => e.M130).HasDefaultValue(0L);
            entity.Property(e => e.M132).HasDefaultValue(0L);
            entity.Property(e => e.M134).HasDefaultValue(0L);
            entity.Property(e => e.M136).HasDefaultValue(0L);
            entity.Property(e => e.M138).HasDefaultValue(0L);
            entity.Property(e => e.M160).HasDefaultValue(0L);
            entity.Property(e => e.M162).HasDefaultValue(0L);
            entity.Property(e => e.M164).HasDefaultValue(0L);
            entity.Property(e => e.M184).HasDefaultValue(0L);
            entity.Property(e => e.M186).HasDefaultValue(0L);
            entity.Property(e => e.M188).HasDefaultValue(0L);
            entity.Property(e => e.M2).HasDefaultValue(0L);
            entity.Property(e => e.M29).HasDefaultValue(0L);
            entity.Property(e => e.M3).HasDefaultValue(0L);
            entity.Property(e => e.M36).HasDefaultValue(0L);
            entity.Property(e => e.M4).HasDefaultValue(0L);
            entity.Property(e => e.M4096).HasDefaultValue(0L);
            entity.Property(e => e.M46).HasDefaultValue(0L);
            entity.Property(e => e.M5).HasDefaultValue(0L);
            entity.Property(e => e.M50).HasDefaultValue(0L);
            entity.Property(e => e.M88).HasDefaultValue(0L);
        });

        modelBuilder.Entity<financial_report>(entity =>
        {
            entity.Property(e => e.AFT_IN).HasDefaultValue(0L);
            entity.Property(e => e.AFT_OUT).HasDefaultValue(0L);
            entity.Property(e => e.BILL_COLLECTED).HasDefaultValue(0L);
            entity.Property(e => e.BILL_IN).HasDefaultValue(0L);
            entity.Property(e => e.CANCEL_CREDIT).HasDefaultValue(0L);
            entity.Property(e => e.CASH_OUT_JACKPOT_PROGRESSIVE_CANCEL_CREDIT).HasDefaultValue(0L);
            entity.Property(e => e.JACKPOT).HasDefaultValue(0L);
            entity.Property(e => e.JACKPOT_PROGRESSIVE_CANCEL_CREDIT).HasDefaultValue(0L);
            entity.Property(e => e.M0).HasDefaultValue(0L);
            entity.Property(e => e.M1).HasDefaultValue(0L);
            entity.Property(e => e.M10).HasDefaultValue(0L);
            entity.Property(e => e.M11).HasDefaultValue(0L);
            entity.Property(e => e.M128).HasDefaultValue(0L);
            entity.Property(e => e.M130).HasDefaultValue(0L);
            entity.Property(e => e.M132).HasDefaultValue(0L);
            entity.Property(e => e.M134).HasDefaultValue(0L);
            entity.Property(e => e.M136).HasDefaultValue(0L);
            entity.Property(e => e.M138).HasDefaultValue(0L);
            entity.Property(e => e.M160).HasDefaultValue(0L);
            entity.Property(e => e.M162).HasDefaultValue(0L);
            entity.Property(e => e.M164).HasDefaultValue(0L);
            entity.Property(e => e.M184).HasDefaultValue(0L);
            entity.Property(e => e.M186).HasDefaultValue(0L);
            entity.Property(e => e.M188).HasDefaultValue(0L);
            entity.Property(e => e.M2).HasDefaultValue(0L);
            entity.Property(e => e.M29).HasDefaultValue(0L);
            entity.Property(e => e.M3).HasDefaultValue(0L);
            entity.Property(e => e.M36).HasDefaultValue(0L);
            entity.Property(e => e.M4).HasDefaultValue(0L);
            entity.Property(e => e.M4096).HasDefaultValue(0L);
            entity.Property(e => e.M46).HasDefaultValue(0L);
            entity.Property(e => e.M5).HasDefaultValue(0L);
            entity.Property(e => e.M50).HasDefaultValue(0L);
            entity.Property(e => e.M88).HasDefaultValue(0L);
            entity.Property(e => e.NET_HOLD).HasDefaultValue(0.0);
            entity.Property(e => e.NET_WIN).HasDefaultValue(0L);
            entity.Property(e => e.PROGRESSIVE).HasDefaultValue(0L);
            entity.Property(e => e.TICKET_COLLECTED).HasDefaultValue(0L);
            entity.Property(e => e.TICKET_COLLECTED_PROMO).HasDefaultValue(0L);
            entity.Property(e => e.TICKET_IN).HasDefaultValue(0L);
            entity.Property(e => e.TICKET_OUT).HasDefaultValue(0L);
            entity.Property(e => e.TOTAL_DROP).HasDefaultValue(0L);
            entity.Property(e => e.WIN_METER).HasDefaultValue(0L);
        });

        modelBuilder.Entity<game>(entity =>
        {
            entity.Property(e => e.gm_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<game_meter>(entity =>
        {
            entity.Property(e => e.gm_delta_handpays_amount).HasDefaultValue(0m);
            entity.Property(e => e.gm_delta_jackpot_amount).HasDefaultValue(0m);
            entity.Property(e => e.gm_delta_played_amount).HasDefaultValue(0m);
            entity.Property(e => e.gm_delta_played_count).HasDefaultValue(0L);
            entity.Property(e => e.gm_delta_updating).HasDefaultValue(false);
            entity.Property(e => e.gm_delta_won_amount).HasDefaultValue(0m);
            entity.Property(e => e.gm_delta_won_count).HasDefaultValue(0L);
        });

        modelBuilder.Entity<game_type>(entity =>
        {
            entity.Property(e => e.gt_language_id).HasDefaultValue(10);
        });

        modelBuilder.Entity<gamegateway_bet>(entity =>
        {
            entity.HasKey(e => new { e.gb_game_id, e.gb_game_instance_id, e.gb_partner_id, e.gb_transaction_type, e.gb_transaction_id, e.gb_account_id }).HasName("PK_gamegateway_bets_1");

            entity.Property(e => e.gb_last_updated)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<gamegateway_game>(entity =>
        {
            entity.Property(e => e.gg_last_updated)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.gg_show_lcd_message).HasDefaultValue(true);
        });

        modelBuilder.Entity<gamegateway_game_instance>(entity =>
        {
            entity.Property(e => e.ggi_last_updated)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.ggi_num_bets_rollback).HasDefaultValue(0);
        });

        modelBuilder.Entity<gaming_hall_group_added>(entity =>
        {
            entity.Property(e => e.ghga_collection_group_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<gaming_hall_group_detail>(entity =>
        {
            entity.HasKey(e => e.ghgd_mc_collection_id).HasName("PK_gaming_hall_group_detail_");

            entity.Property(e => e.ghgd_mc_collection_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<gaming_table>(entity =>
        {
            entity.Property(e => e.gt_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<gaming_tables_connected>(entity =>
        {
            entity.HasKey(e => new { e.gmc_gamingtable_id, e.gmc_gaming_day }).HasName("PK_Gaming_Tables_Connected");
        });

        modelBuilder.Entity<gaming_tables_sessions_by_currency>(entity =>
        {
            entity.Property(e => e.gtsc_tax).HasDefaultValue(0m);
        });

        modelBuilder.Entity<gaming_tables_win_loss_detail>(entity =>
        {
            entity.Property(e => e.gtwld_quantity).HasComment("Do not use negative values to differentiate check or card. Use 1 for quantity and in denomination the value of the check or card. Amount per denomination must be the total.");
        });

        modelBuilder.Entity<gds_group_element>(entity =>
        {
            entity.Property(e => e.gge_is_group).HasComment("0 - Single Element; 1 - Group Definition");
        });

        modelBuilder.Entity<gift_instance>(entity =>
        {
            entity.Property(e => e.gin_row_version)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<gt_play_session>(entity =>
        {
            entity.Property(e => e.gtps_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<gt_sessions_conciliate>(entity =>
        {
            entity.HasKey(e => e.gtsc_session_id).HasName("PK_gaming_tables_sessions_conciliate");

            entity.Property(e => e.gtsc_session_id).ValueGeneratedNever();
            entity.Property(e => e.gtsc_created).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<gui_user>(entity =>
        {
            entity.Property(e => e.gu_user_id).ValueGeneratedNever();
            entity.Property(e => e.gu_password).IsFixedLength();
            entity.Property(e => e.gu_password_h1).IsFixedLength();
            entity.Property(e => e.gu_password_h2).IsFixedLength();
            entity.Property(e => e.gu_password_h3).IsFixedLength();
            entity.Property(e => e.gu_password_h4).IsFixedLength();
            entity.Property(e => e.gu_password_h5).IsFixedLength();
            entity.Property(e => e.gu_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.gu_user_type).HasComment("0 - USER, 1 - SYSTEM, 10 - SUPERUSER");
        });

        modelBuilder.Entity<gui_user_profile>(entity =>
        {
            entity.Property(e => e.gup_profile_id).ValueGeneratedNever();
            entity.Property(e => e.gup_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<gui_user_venue>(entity =>
        {
            entity.Property(e => e.guv_user_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<h_m2d_smh>(entity =>
        {
            entity.HasKey(e => new { e.x2d_date, e.x2d_weekday, e.x2d_id, e.x2d_meter_id, e.x2d_meter_item }).HasName("PK_M2D_SMH");
        });

        modelBuilder.Entity<h_m2d_tmh>(entity =>
        {
            entity.HasKey(e => new { e.x2d_date, e.x2d_weekday, e.x2d_id, e.x2d_meter_id, e.x2d_meter_item }).HasName("PK_M2D_TMH");
        });

        modelBuilder.Entity<h_pvh>(entity =>
        {
            entity.HasKey(e => new { e.pvh_account_id, e.pvh_date }).HasName("pk_h_pvh");
        });

        modelBuilder.Entity<h_t2d_smh>(entity =>
        {
            entity.HasKey(e => new { e.x2d_date, e.x2d_weekday, e.x2d_id, e.x2d_meter_id, e.x2d_meter_item }).HasName("PK_T2D_SMH");
        });

        modelBuilder.Entity<h_t2d_tmh>(entity =>
        {
            entity.HasKey(e => new { e.x2d_date, e.x2d_weekday, e.x2d_id, e.x2d_meter_id, e.x2d_meter_item }).HasName("PK_T2D_TMH");
        });

        modelBuilder.Entity<h_w2d_smh>(entity =>
        {
            entity.HasKey(e => new { e.x2d_date, e.x2d_weekday, e.x2d_id, e.x2d_meter_id, e.x2d_meter_item }).HasName("PK_W2D_SMH");
        });

        modelBuilder.Entity<h_w2d_tmh>(entity =>
        {
            entity.HasKey(e => new { e.x2d_date, e.x2d_weekday, e.x2d_id, e.x2d_meter_id, e.x2d_meter_item }).HasName("PK_W2D_TMH");
        });

        modelBuilder.Entity<h_x2d_control>(entity =>
        {
            entity.HasKey(e => new { e.x2d_date, e.x2d_meter_type }).HasName("PK_H_X2D_CONTROL");
        });

        modelBuilder.Entity<h_y2d_smh>(entity =>
        {
            entity.HasKey(e => new { e.x2d_date, e.x2d_weekday, e.x2d_id, e.x2d_meter_id, e.x2d_meter_item }).HasName("PK_Y2D_SMH");
        });

        modelBuilder.Entity<h_y2d_tmh>(entity =>
        {
            entity.HasKey(e => new { e.x2d_date, e.x2d_weekday, e.x2d_id, e.x2d_meter_id, e.x2d_meter_item }).HasName("PK_Y2D_TMH");
        });

        modelBuilder.Entity<handpay>(entity =>
        {
            entity.Property(e => e.HP_TIMESTAMP)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<handpays_changes_audit>(entity =>
        {
            entity.HasKey(e => new { e.hca_hpid, e.hca_id }).HasName("PK_handpays_audit");
        });

        modelBuilder.Entity<hierarchy_group_element>(entity =>
        {
            entity.Property(e => e.hge_id).ValueGeneratedNever();
            entity.Property(e => e.hge_enabled).HasDefaultValue(true);
        });

        modelBuilder.Entity<hierarchy_organization>(entity =>
        {
            entity.Property(e => e.ho_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<hierarchy_tree>(entity =>
        {
            entity.HasKey(e => e.ht_id).HasName("PK_htree");

            entity.Property(e => e.ht_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<hierarchy_venue>(entity =>
        {
            entity.HasKey(e => e.hv_id).HasName("PK__hierarch__04FCFF8106EF8466");

            entity.Property(e => e.hv_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<history_ms_site_dynamic_table>(entity =>
        {
            entity.HasIndex(e => e.hmsdt_timestamp, "IX_hmsdt_timestamp")
                .IsUnique()
                .HasFilter("([hmsdt_timestamp] IS NOT NULL)");

            entity.Property(e => e.hmsdt_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<history_stats_to_work>(entity =>
        {
            entity.HasKey(e => new { e.hsw_day_to_process, e.hsw_type }).HasName("PK_hsw_day_to_process");
        });

        modelBuilder.Entity<hot_seats_launch_parameter>(entity =>
        {
            entity.Property(e => e.hslp_hs_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<hourly_take_out>(entity =>
        {
            entity.Property(e => e.hto_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<hpc_meter>(entity =>
        {
            entity.Property(e => e.hpc_terminal_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<identification_type>(entity =>
        {
            entity.Property(e => e.idt_id).ValueGeneratedNever();
            entity.Property(e => e.idt_country_iso_code2).HasDefaultValue("MX");
            entity.Property(e => e.idt_enabled).HasDefaultValue(true);
        });

        modelBuilder.Entity<intouch_terminal_activity>(entity =>
        {
            entity.Property(e => e.ita_terminal_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<jackpot_tax_template>(entity =>
        {
            entity.Property(e => e.jtt_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<jackpots_amount_terminal>(entity =>
        {
            entity.HasKey(e => e.jat_terminal_id).HasName("PK_jat_terminal_id");

            entity.Property(e => e.jat_terminal_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<jackpots_viewers_related_jackpot>(entity =>
        {
            entity.HasKey(e => new { e.jvj_id, e.jvj_jackpot_viewer_id, e.jvj_jackpot_id }).HasName("PK_JACKPOTS_VIEWERS_RELATED_JACKPOT");
        });

        modelBuilder.Entity<layout_dashboard>(entity =>
        {
            entity.Property(e => e.ld_role_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<layout_mesh>(entity =>
        {
            entity.Property(e => e.lme_mesh_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<layout_mobile_application_version>(entity =>
        {
            entity.Property(e => e.lmav_version).IsFixedLength();
        });

        modelBuilder.Entity<layout_notification>(entity =>
        {
            entity.Property(e => e.ln_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<layout_parameter>(entity =>
        {
            entity.Property(e => e.lp_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<layout_permitted_alarm>(entity =>
        {
            entity.HasKey(e => e.lpa_alarm_id).HasName("PK_permitted_alarms");

            entity.Property(e => e.lpa_alarm_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<layout_ranges_legend>(entity =>
        {
            entity.Property(e => e.lrl_operator).IsFixedLength();
        });

        modelBuilder.Entity<layout_site_alarm>(entity =>
        {
            entity.HasKey(e => new { e.lsa_terminal_id, e.lsa_alarm_id, e.lsa_date_created }).HasName("PK_layout_site_alarms_1");

            entity.HasIndex(e => e.lsa_external_id, "UNIQUE_EXTERNAL_ID")
                .IsUnique()
                .HasFilter("([lsa_external_id] IS NOT NULL)");
        });

        modelBuilder.Entity<layout_users_configuration>(entity =>
        {
            entity.HasKey(e => e.lc_user_id).HasName("PK_layout_configuration");

            entity.Property(e => e.lc_user_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<layout_view>(entity =>
        {
            entity.Property(e => e.lv_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<layout_weather_diary>(entity =>
        {
            entity.Property(e => e.lwd_date).ValueGeneratedNever();
        });

        modelBuilder.Entity<lcd_functionality>(entity =>
        {
            entity.HasKey(e => e.fun_function_id).HasName("PK_LCD_functionalities");

            entity.Property(e => e.fun_function_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<lcd_image>(entity =>
        {
            entity.HasKey(e => e.cim_image_id).HasName("PK_LCD_images");

            entity.Property(e => e.cim_image_id).ValueGeneratedNever();
            entity.Property(e => e.cim_resource_name).HasDefaultValue("");
        });

        modelBuilder.Entity<lcd_message>(entity =>
        {
            entity.Property(e => e.msg_unique_id).ValueGeneratedNever();
            entity.Property(e => e.msg_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<lcd_nls_resource>(entity =>
        {
            entity.HasKey(e => e.nres_id).HasName("PK_LCD_nls_resources");

            entity.Property(e => e.nres_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<lcd_package>(entity =>
        {
            entity.HasKey(e => e.LP_WPK_ID).HasName("PK_LP_PACKAGE");

            entity.Property(e => e.LP_WPK_ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<licence>(entity =>
        {
            entity.Property(e => e.wl_insertion_date).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<live_operation>(entity =>
        {
            entity.Property(e => e.lo_operation_guid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.lo_datetime).HasDefaultValueSql("(sysdatetimeoffset())");
        });

        modelBuilder.Entity<live_operations_last_processed>(entity =>
        {
            entity.Property(e => e.lolc_venue_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<live_operations_session>(entity =>
        {
            entity.Property(e => e.los_cashier_session_id).ValueGeneratedNever();
            entity.Property(e => e.los_insertion_datetime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<lotery_hp_mark>(entity =>
        {
            entity.Property(e => e.lhm_next_id).HasDefaultValue(1);
        });

        modelBuilder.Entity<machine_denom_stats_per_hour>(entity =>
        {
            entity.Property(e => e.mdsh_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<machine_meter>(entity =>
        {
            entity.Property(e => e.mm_terminal_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<machine_stats_per_hour>(entity =>
        {
            entity.Property(e => e.msh_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<major_prizes_to_generate>(entity =>
        {
            entity.Property(e => e.mpg_operation_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<meter>(entity =>
        {
            entity.Property(e => e.me_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<mobile_bank>(entity =>
        {
            entity.Property(e => e.mb_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<money_collection_meter>(entity =>
        {
            entity.Property(e => e.mcm_session_id).ValueGeneratedNever();
            entity.Property(e => e.mcm_total_coin_amount).HasDefaultValue(0m);
        });

        modelBuilder.Entity<money_collection_meters_out>(entity =>
        {
            entity.Property(e => e.mcmo_session_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<money_collections_grouped>(entity =>
        {
            entity.Property(e => e.mcg_money_collection_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<money_collections_history>(entity =>
        {
            entity.HasKey(e => new { e.mch_gaming_day, e.mch_tid, e.mch_money_collection_id }).HasName("PK_gamingday_tid_collectionid");
        });

        modelBuilder.Entity<money_meter>(entity =>
        {
            entity.Property(e => e.mm_cash_type).HasComment("1-CashIn, 2-CashOut");
            entity.Property(e => e.mm_money_type).HasComment("1-Note, 2-Coin");
            entity.Property(e => e.mm_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<movement_tracking_type>(entity =>
        {
            entity.Property(e => e.mtt_name).IsFixedLength();
        });

        modelBuilder.Entity<ms_pending_account_flag>(entity =>
        {
            entity.Property(e => e.mpaf_unique_id).ValueGeneratedNever();
            entity.Property(e => e.mpaf_datetime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<ms_pending_account_movement>(entity =>
        {
            entity.Property(e => e.mpam_movement_id).ValueGeneratedNever();
            entity.Property(e => e.mpam_datetime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<ms_pending_account_operation>(entity =>
        {
            entity.Property(e => e.mpao_operation_id).ValueGeneratedNever();
            entity.Property(e => e.mpao_datetime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<ms_pending_game_play_session>(entity =>
        {
            entity.HasKey(e => e.mps_play_session_id).HasName("PK_ms_site_pending_play_sessions");

            entity.Property(e => e.mps_play_session_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ms_pending_task68_work_datum>(entity =>
        {
            entity.HasKey(e => e.mptwd_operation_id).HasName("PK_TASK68_WORK_DATA");

            entity.Property(e => e.mptwd_operation_id).ValueGeneratedNever();
            entity.Property(e => e.mptwd_datetime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<ms_site_pending_account>(entity =>
        {
            entity.Property(e => e.spa_account_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ms_site_pending_account_document>(entity =>
        {
            entity.HasKey(e => e.pad_account_id).HasName("PK_ms_pending_accounts_documents");

            entity.Property(e => e.pad_account_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ms_site_pending_account_movement>(entity =>
        {
            entity.Property(e => e.spm_movement_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ms_site_pending_account_promotion>(entity =>
        {
            entity.HasKey(e => e.pap_ms_id).HasName("PK_ms_site_pending_account_promotions_1");

            entity.Property(e => e.pap_ms_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ms_site_pending_customer>(entity =>
        {
            entity.Property(e => e.spc_customer_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ms_site_pending_customer_record_detail>(entity =>
        {
            entity.Property(e => e.spcrd_curd_detail_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ms_site_pending_last_activity>(entity =>
        {
            entity.Property(e => e.laa_account_id).ValueGeneratedNever();
            entity.Property(e => e.laa_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ms_site_pending_merge_customers_balance>(entity =>
        {
            entity.Property(e => e.spmcb_customer_target_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ms_site_task>(entity =>
        {
            entity.HasKey(e => e.st_task_id).HasName("PK_ms_site_synch_control");

            entity.Property(e => e.st_task_id).ValueGeneratedNever();
            entity.Property(e => e.st_enabled).HasDefaultValue(true);
            entity.Property(e => e.st_max_rows_to_upload).HasDefaultValue(100);
        });

        modelBuilder.Entity<nls_app_language>(entity =>
        {
            entity.Property(e => e.nls_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<note_counter>(entity =>
        {
            entity.Property(e => e.nc_application_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<notice>(entity =>
        {
            entity.HasKey(e => e.no_notice_code).HasName("PK_Notices");

            entity.Property(e => e.no_notice_code).ValueGeneratedNever();
        });

        modelBuilder.Entity<notice_account_movement>(entity =>
        {
            entity.Property(e => e.mn_movement_notice_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<notice_group>(entity =>
        {
            entity.HasKey(e => e.ng_group_id).HasName("PK_Notice_Groups");

            entity.Property(e => e.ng_group_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<online_player_tracking>(entity =>
        {
            entity.HasKey(e => new { e.opt_type, e.opt_account_id }).HasName("pk_online_player_tracking");
        });

        modelBuilder.Entity<operation_voucher_parameter>(entity =>
        {
            entity.Property(e => e.ovp_operation_code).ValueGeneratedNever();
        });

        modelBuilder.Entity<operations_after_hour>(entity =>
        {
            entity.HasKey(e => e.oah_from).HasName("PK_OPERATIONS_AFTER_HOURS");
        });

        modelBuilder.Entity<operations_schedule_status>(entity =>
        {
            entity.HasKey(e => e.oss_type).HasName("PK_operations_allowed");

            entity.Property(e => e.oss_type).ValueGeneratedNever();
        });

        modelBuilder.Entity<patron_summary_history>(entity =>
        {
            entity.Property(e => e.psh_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<pending_play_sessions_to_player_tracking>(entity =>
        {
            entity.Property(e => e.pps_session_id).ValueGeneratedNever();
            entity.Property(e => e.pps_datetimecreated).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<pinpad_transactions_reconciliation>(entity =>
        {
            entity.Property(e => e.ptc_code).HasDefaultValue(0L);
            entity.Property(e => e.ptc_drawal_status).HasDefaultValue(false);
        });

        modelBuilder.Entity<play_safe_similar_terminal>(entity =>
        {
            entity.Property(e => e.psst_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<play_safe_terminal_notification>(entity =>
        {
            entity.Property(e => e.pstn_terminal_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<play_safe_terminal_pending>(entity =>
        {
            entity.Property(e => e.pstp_id).ValueGeneratedNever();
            entity.Property(e => e.pstp_inserted).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<play_safe_terminal_processed_group>(entity =>
        {
            entity.HasKey(e => e.psep_id).HasName("PK_play_safe.terminal_process_group");

            entity.Property(e => e.psep_id).ValueGeneratedNever();
            entity.Property(e => e.psep_datime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<play_safe_terminal_status>(entity =>
        {
            entity.Property(e => e.psts_terminal_id).ValueGeneratedNever();
            entity.Property(e => e.psts_blocked).HasDefaultValue((short)0);
            entity.Property(e => e.psts_clean_pending).HasDefaultValue((short)0);
            entity.Property(e => e.psts_current_change_id).HasDefaultValue(1L);
            entity.Property(e => e.psts_final_pending_notification).HasDefaultValue((short)0);
            entity.Property(e => e.psts_final_status_code).HasDefaultValue((short)0);
            entity.Property(e => e.psts_neighbor_playing).HasDefaultValue((short)0);
            entity.Property(e => e.psts_neighbor_reserved).HasDefaultValue((short)0);
            entity.Property(e => e.psts_playing).HasDefaultValue((short)0);
            entity.Property(e => e.psts_playing_account_id).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.psts_reserved).HasDefaultValue((short)0);
            entity.Property(e => e.psts_reserved_account_id).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.psts_toggle).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<play_session>(entity =>
        {
            entity.Property(e => e.ps_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<play_sessions_assignments_history>(entity =>
        {
            entity.Property(e => e.psa_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<play_sessions_theo_win_to_historify>(entity =>
        {
            entity.Property(e => e.psth_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<players_online>(entity =>
        {
            entity.HasKey(e => e.po_terminal_id).HasName("PK__players___F4C4B19F1E1E2AAA");

            entity.Property(e => e.po_terminal_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<progressives_level>(entity =>
        {
            entity.Property(e => e.pgl_show_on_winup).HasDefaultValue(true);
        });

        modelBuilder.Entity<promogame_type_play_session>(entity =>
        {
            entity.HasKey(e => e.ptp_playsession_id).HasName("PK_promogametype_playsession");

            entity.Property(e => e.ptp_playsession_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<promotion_category>(entity =>
        {
            entity.Property(e => e.pc_language_id).HasDefaultValue(10);
        });

        modelBuilder.Entity<promotion_flag>(entity =>
        {
            entity.Property(e => e.pf_flag_count_excluded).HasDefaultValueSql("(NULL)");
        });

        modelBuilder.Entity<provider>(entity =>
        {
            entity.Property(e => e.pv_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<provider_model>(entity =>
        {
            entity.Property(e => e.pm_model_id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<report>(entity =>
        {
            entity.Property(e => e.rep_created).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<reserved_terminal_configuration>(entity =>
        {
            entity.HasKey(e => e.rtc_holder_level).HasName("pk_reserved_terminal_configuration");

            entity.Property(e => e.rtc_holder_level).ValueGeneratedNever();
            entity.Property(e => e.rtc_coin_in).HasDefaultValue(0m);
            entity.Property(e => e.rtc_enabled).HasDefaultValue(false);
        });

        modelBuilder.Entity<reserved_terminals_by_tier>(entity =>
        {
            entity.Property(e => e.rtt_terminal_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<sales_interface>(entity =>
        {
            entity.HasKey(e => e.si_frame).HasName("PK__sales_in__368D893A19122A37");
        });

        modelBuilder.Entity<sales_per_hour>(entity =>
        {
            entity.HasIndex(e => new { e.sph_base_hour, e.sph_terminal_id, e.sph_game_id }, "PK_sales_per_hour")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.sph_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<sas_meters_catalog>(entity =>
        {
            entity.Property(e => e.smc_meter_code).ValueGeneratedNever();
        });

        modelBuilder.Entity<sas_meters_group>(entity =>
        {
            entity.Property(e => e.smg_group_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<sequence>(entity =>
        {
            entity.Property(e => e.seq_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<service_component>(entity =>
        {
            entity.Property(e => e.sc_packet_type).ValueGeneratedNever();
        });

        modelBuilder.Entity<service_internet_connection>(entity =>
        {
            entity.Property(e => e.sic_protocol).IsFixedLength();
            entity.Property(e => e.sic_server_name).IsFixedLength();
        });

        modelBuilder.Entity<site>(entity =>
        {
            entity.Property(e => e.st_id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<site1>(entity =>
        {
            entity.Property(e => e.st_site_id).ValueGeneratedNever();
            entity.Property(e => e.st_elp).HasDefaultValue(false);
        });

        modelBuilder.Entity<site_jackpot_instance>(entity =>
        {
            entity.Property(e => e.sji_index).ValueGeneratedNever();
            entity.Property(e => e.sji_show_on_winup).HasDefaultValue(true);
        });

        modelBuilder.Entity<site_jackpot_parameter>(entity =>
        {
            entity.Property(e => e.SJP_EXCEED_MAXIMUM_ALLOWED).HasDefaultValue(true);
            entity.Property(e => e.sjp_animation_interval).HasDefaultValue(15);
            entity.Property(e => e.sjp_award_mode).HasDefaultValue(1);
            entity.Property(e => e.sjp_awarding_days).HasDefaultValue(127);
            entity.Property(e => e.sjp_awarding_end).HasDefaultValue(86399);
            entity.Property(e => e.sjp_awarding_exclude_anonymous).HasDefaultValue(true);
            entity.Property(e => e.sjp_awarding_exclude_promotions).HasDefaultValue(true);
            entity.Property(e => e.sjp_contribution_fix).HasDefaultValue(true);
            entity.Property(e => e.sjp_recent_interval).HasDefaultValue(3600);
        });

        modelBuilder.Entity<smib_communication_type>(entity =>
        {
            entity.Property(e => e.sct_id).ValueGeneratedNever();
            entity.Property(e => e.sct_active).HasDefaultValue(true);
        });

        modelBuilder.Entity<sph_control>(entity =>
        {
            entity.Property(e => e.sphc_last_play_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<stacker>(entity =>
        {
            entity.Property(e => e.st_stacker_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<tax_by_country>(entity =>
        {
            entity.HasKey(e => new { e.tbc_country_id, e.tbc_tax_type }).HasName("PK_jtc_country_id");

            entity.Property(e => e.tbc_tax1_percentage).HasDefaultValue(0m);
            entity.Property(e => e.tbc_tax2_percentage).HasDefaultValue(0m);
            entity.Property(e => e.tbc_tax3_percentage).HasDefaultValue(0m);
        });

        modelBuilder.Entity<tax_report_bill_in>(entity =>
        {
            entity.Property(e => e.trbi_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<terminal>(entity =>
        {
            entity.Property(e => e.te_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<terminal_game_translation>(entity =>
        {
            entity.Property(e => e.tgt_created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.tgt_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.tgt_translated_game_id).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.tgt_updated).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<terminal_money>(entity =>
        {
            entity.Property(e => e.tm_into_acceptor).HasDefaultValue(true);
            entity.Property(e => e.tm_reported).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<terminal_sas_meters_history>(entity =>
        {
            entity.Property(e => e.tsmh_created_datetime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<terminal_sas_meters_history_pending>(entity =>
        {
            entity.Property(e => e.tsmhp_terminal_id).ValueGeneratedNever();
            entity.Property(e => e.tsmhp_created_datetime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.tsmhp_update_datetime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<terminal_sas_meters_msg_configuration>(entity =>
        {
            entity.Property(e => e.tsmmc_config_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<terminal_sas_meters_msg_last_configuration>(entity =>
        {
            entity.Property(e => e.tlsmmc_created_date).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.tlsmmc_update_date).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<terminal_sas_meters_msg_value>(entity =>
        {
            entity.Property(e => e.tsmmv_values_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<terminal_sas_meters_pre_history>(entity =>
        {
            entity.Property(e => e.tsmph_created_datetime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<terminal_setting>(entity =>
        {
            entity.Property(e => e.ts_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<terminal_software_version>(entity =>
        {
            entity.HasKey(e => new { e.tsv_terminal_type, e.tsv_version }).HasName("PK_kiosk_software_versions");

            entity.Property(e => e.tsv_version).HasDefaultValue("");
            entity.Property(e => e.tsv_insertion_date).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<terminal_status>(entity =>
        {
            entity.Property(e => e.ts_terminal_id).ValueGeneratedNever();
            entity.Property(e => e.ts_call_attendant_flags).HasDefaultValue(0);
            entity.Property(e => e.ts_player_flags).HasDefaultValue(0);
        });

        modelBuilder.Entity<terminal_type>(entity =>
        {
            entity.Property(e => e.tt_type).ValueGeneratedNever();
            entity.Property(e => e.tt_name).IsFixedLength();
        });

        modelBuilder.Entity<terminals_connected>(entity =>
        {
            entity.Property(e => e.tc_connected).HasDefaultValue(true);
            entity.Property(e => e.tc_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<terminals_time_disconnected>(entity =>
        {
            entity.HasKey(e => new { e.ttd_site_id, e.ttd_terminal_id, e.ttd_working_day }).HasName("PK_ttd_id");
        });

        modelBuilder.Entity<tickets_audit_status_change>(entity =>
        {
            entity.HasKey(e => new { e.tia_id, e.tia_validation_number }).HasName("PK_tickets_audit");
        });

        modelBuilder.Entity<venue_status>(entity =>
        {
            entity.Property(e => e.ves_venue_status_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<venue_type>(entity =>
        {
            entity.HasKey(e => e.vet_venues_types_id).HasName("PK_venues_types");

            entity.Property(e => e.vet_venues_types_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<wc2_session>(entity =>
        {
            entity.Property(e => e.w2s_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<wc2_transaction>(entity =>
        {
            entity.Property(e => e.w2tx_status).HasComment("0 - Running, 1 - Finished");
        });

        modelBuilder.Entity<wcp_services_to_cj_queue>(entity =>
        {
            entity.HasKey(e => e.wscq_service_id).HasName("PK_wcp_services_to_cj_queues_1");

            entity.Property(e => e.wscq_service_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<wcp_session>(entity =>
        {
            entity.Property(e => e.ws_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<wcp_transaction>(entity =>
        {
            entity.Property(e => e.wtx_status).HasComment("0 - Running, 1 - Finished");
        });

        modelBuilder.Entity<win_loss_statement>(entity =>
        {
            entity.Property(e => e.wls_request_date).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<wkt_ad_step_detail>(entity =>
        {
            entity.Property(e => e.ascr_step_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<wkt_functionality>(entity =>
        {
            entity.Property(e => e.fun_function_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<wkt_image>(entity =>
        {
            entity.Property(e => e.cim_image_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<wkt_player_info_field>(entity =>
        {
            entity.Property(e => e.pif_field_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<wrkp_kiosk_status>(entity =>
        {
            entity.HasKey(e => e.wks_cr_id).HasName("PK_wrpk_kiosk_status");

            entity.Property(e => e.wks_cr_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<wwp_status>(entity =>
        {
            entity.Property(e => e.wwp_type).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
