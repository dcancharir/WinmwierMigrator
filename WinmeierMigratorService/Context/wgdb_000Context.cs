using Microsoft.EntityFrameworkCore;
using WinmeierMigratorService.Models;

namespace WinmeierMigratorService.Context;

public partial class wgdb_000Context : DbContext
{
    public wgdb_000Context()
    {
    }

    public wgdb_000Context(DbContextOptions<wgdb_000Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Card_Generation> Card_Generations { get; set; }

    public virtual DbSet<ErrorHandling> ErrorHandlings { get; set; }

    public virtual DbSet<MIGRATION_ACCOUNT> MIGRATION_ACCOUNTs { get; set; }

    public virtual DbSet<MIGRATION_TABLE> MIGRATION_TABLEs { get; set; }

    public virtual DbSet<PRELIC> PRELICs { get; set; }

    public virtual DbSet<PROVIDERS_GAMES_FINALLY> PROVIDERS_GAMES_FINALLies { get; set; }

    public virtual DbSet<RESULTADO> RESULTADOs { get; set; }

    public virtual DbSet<Resultado_fragment> Resultado_fragments { get; set; }

    public virtual DbSet<Resultado_size> Resultado_sizes { get; set; }

    public virtual DbSet<SAVED_CHANGE_POINT> SAVED_CHANGE_POINTs { get; set; }

    public virtual DbSet<SAVED_EXPIRED_CREDITS_AM> SAVED_EXPIRED_CREDITS_AMs { get; set; }

    public virtual DbSet<SAVED_EXPIRED_CREDITS_CM> SAVED_EXPIRED_CREDITS_CMs { get; set; }

    public virtual DbSet<TABLESFRAGMENT> TABLESFRAGMENTs { get; set; }

    public virtual DbSet<TABLESIZE> TABLESIZEs { get; set; }

    public virtual DbSet<TMP_TERMINALS_TO_BASE_NAME> TMP_TERMINALS_TO_BASE_NAMEs { get; set; }

    public virtual DbSet<Temp_account_point> Temp_account_points { get; set; }

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

    public virtual DbSet<account_operation> account_operations { get; set; }

    public virtual DbSet<account_payment_order> account_payment_orders { get; set; }

    public virtual DbSet<account_photo> account_photos { get; set; }

    public virtual DbSet<account_points_cache> account_points_caches { get; set; }

    public virtual DbSet<account_points_expired_control> account_points_expired_controls { get; set; }

    public virtual DbSet<account_points_expired_list> account_points_expired_lists { get; set; }

    public virtual DbSet<account_promotion> account_promotions { get; set; }

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

    public virtual DbSet<bank> banks { get; set; }

    public virtual DbSet<bank_account> bank_accounts { get; set; }

    public virtual DbSet<bank_transaction> bank_transactions { get; set; }

    public virtual DbSet<blacklist_file_imported> blacklist_file_importeds { get; set; }

    public virtual DbSet<blacklist_file_imported_type> blacklist_file_imported_types { get; set; }

    public virtual DbSet<blacklist_internal_block_list> blacklist_internal_block_lists { get; set; }

    public virtual DbSet<bonuse> bonuses { get; set; }

    public virtual DbSet<bucket> buckets { get; set; }

    public virtual DbSet<bucket_level> bucket_levels { get; set; }

    public virtual DbSet<buckets_multiplier_schedule> buckets_multiplier_schedules { get; set; }

    public virtual DbSet<buckets_multiplier_to_apply> buckets_multiplier_to_applies { get; set; }

    public virtual DbSet<buffer_alarm> buffer_alarms { get; set; }

    public virtual DbSet<buffer_handpay> buffer_handpays { get; set; }

    public virtual DbSet<buffer_terminal_sas_meter> buffer_terminal_sas_meters { get; set; }

    public virtual DbSet<buffer_terminal_sas_meters_history> buffer_terminal_sas_meters_histories { get; set; }

    public virtual DbSet<buffer_terminals_connected> buffer_terminals_connecteds { get; set; }

    public virtual DbSet<buffer_terminals_time_disconnected> buffer_terminals_time_disconnecteds { get; set; }

    public virtual DbSet<buffer_wc2Session> buffer_wc2Sessions { get; set; }

    public virtual DbSet<buffer_wcpSession> buffer_wcpSessions { get; set; }

    public virtual DbSet<c2_card> c2_cards { get; set; }

    public virtual DbSet<c2_draw_audit> c2_draw_audits { get; set; }

    public virtual DbSet<c2_draw_audit_play> c2_draw_audit_plays { get; set; }


    public virtual DbSet<c2_jackpot_counter> c2_jackpot_counters { get; set; }

    public virtual DbSet<c2_jackpot_history> c2_jackpot_histories { get; set; }

    public virtual DbSet<c2_jackpot_instance> c2_jackpot_instances { get; set; }

    public virtual DbSet<c2_jackpot_parameter> c2_jackpot_parameters { get; set; }

    public virtual DbSet<c2_winning_pattern> c2_winning_patterns { get; set; }

    public virtual DbSet<cage_concept> cage_concepts { get; set; }

    public virtual DbSet<cage_concept_movement_detail> cage_concept_movement_details { get; set; }

    public virtual DbSet<cage_currency> cage_currencies { get; set; }

    public virtual DbSet<cage_meter> cage_meters { get; set; }

    public virtual DbSet<cage_movement> cage_movements { get; set; }

    public virtual DbSet<cage_movement_detail> cage_movement_details { get; set; }

    public virtual DbSet<cage_movement_template> cage_movement_templates { get; set; }

    public virtual DbSet<cage_pending_movement> cage_pending_movements { get; set; }

    public virtual DbSet<cage_session> cage_sessions { get; set; }

    public virtual DbSet<cage_session_meter> cage_session_meters { get; set; }

    public virtual DbSet<cage_source_target> cage_source_targets { get; set; }

    public virtual DbSet<cage_source_target_concept> cage_source_target_concepts { get; set; }

    public virtual DbSet<cage_stock> cage_stocks { get; set; }

    public virtual DbSet<card> cards { get; set; }

    public virtual DbSet<cashdesk_draw> cashdesk_draws { get; set; }

    public virtual DbSet<cashier_movement> cashier_movements { get; set; }

    public virtual DbSet<cashier_movements_grouped_by_hour> cashier_movements_grouped_by_hours { get; set; }

    public virtual DbSet<cashier_movements_grouped_by_session_id> cashier_movements_grouped_by_session_ids { get; set; }

    public virtual DbSet<cashier_movements_pending_history> cashier_movements_pending_histories { get; set; }

    public virtual DbSet<cashier_session> cashier_sessions { get; set; }

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

    public virtual DbSet<currency> currencies { get; set; }

    public virtual DbSet<currency_denomination> currency_denominations { get; set; }

    public virtual DbSet<currency_exchange> currency_exchanges { get; set; }

    public virtual DbSet<currency_exchange_audit> currency_exchange_audits { get; set; }

    public virtual DbSet<customer> customers { get; set; }

    public virtual DbSet<customer_bucket> customer_buckets { get; set; }

    public virtual DbSet<customer_bucket_by_gaming_day> customer_bucket_by_gaming_days { get; set; }

    public virtual DbSet<customer_entrance> customer_entrances { get; set; }

    public virtual DbSet<customer_entrances_price> customer_entrances_prices { get; set; }

    public virtual DbSet<customer_notice> customer_notices { get; set; }

    public virtual DbSet<customer_notices_history> customer_notices_histories { get; set; }

    public virtual DbSet<customer_notices_priority> customer_notices_priorities { get; set; }

    public virtual DbSet<customer_record> customer_records { get; set; }

    public virtual DbSet<customer_record_detail> customer_record_details { get; set; }

    public virtual DbSet<customer_record_details_history> customer_record_details_histories { get; set; }

    public virtual DbSet<customer_records_history> customer_records_histories { get; set; }

    public virtual DbSet<customer_visit> customer_visits { get; set; }

    public virtual DbSet<customer_visit_egm_stat> customer_visit_egm_stats { get; set; }

    public virtual DbSet<customer_visit_gt_stat> customer_visit_gt_stats { get; set; }

    public virtual DbSet<daily_meter> daily_meters { get; set; }

    public virtual DbSet<db_user> db_users { get; set; }

    public virtual DbSet<db_version> db_versions { get; set; }

    public virtual DbSet<db_version_interface_3g> db_version_interface_3gs { get; set; }

    public virtual DbSet<db_version_mywinsy> db_version_mywinsys { get; set; }

    public virtual DbSet<deleted_account> deleted_accounts { get; set; }

    public virtual DbSet<document> documents { get; set; }

    public virtual DbSet<draw> draws { get; set; }

    public virtual DbSet<draw_ticket> draw_tickets { get; set; }

    public virtual DbSet<egm_control_mark> egm_control_marks { get; set; }

    public virtual DbSet<egm_daily> egm_dailies { get; set; }

    public virtual DbSet<egm_meters_by_day> egm_meters_by_days { get; set; }

    public virtual DbSet<egm_meters_by_period> egm_meters_by_periods { get; set; }

    public virtual DbSet<egm_meters_max_value> egm_meters_max_values { get; set; }

    public virtual DbSet<elp01_play_session> elp01_play_sessions { get; set; }

    public virtual DbSet<elp01_space_request> elp01_space_requests { get; set; }

    public virtual DbSet<elp01_voucher> elp01_vouchers { get; set; }

    public virtual DbSet<event_history> event_histories { get; set; }

    public virtual DbSet<external_validation_operation> external_validation_operations { get; set; }

    public virtual DbSet<fbm_log> fbm_logs { get; set; }

    public virtual DbSet<federal_state> federal_states { get; set; }

    public virtual DbSet<flag> flags { get; set; }

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

    public virtual DbSet<gaming_table> gaming_tables { get; set; }

    public virtual DbSet<gaming_table_bet> gaming_table_bets { get; set; }

    public virtual DbSet<gaming_table_chips_set> gaming_table_chips_sets { get; set; }

    public virtual DbSet<gaming_table_configuration> gaming_table_configurations { get; set; }

    public virtual DbSet<gaming_tables_connected> gaming_tables_connecteds { get; set; }

    public virtual DbSet<gaming_tables_session> gaming_tables_sessions { get; set; }

    public virtual DbSet<gaming_tables_sessions_by_currency> gaming_tables_sessions_by_currencies { get; set; }

    public virtual DbSet<gaming_tables_type> gaming_tables_types { get; set; }

    public virtual DbSet<gds_group> gds_groups { get; set; }

    public virtual DbSet<gds_group_element> gds_group_elements { get; set; }

    public virtual DbSet<gds_platform> gds_platforms { get; set; }

    public virtual DbSet<gds_schedule_detail> gds_schedule_details { get; set; }

    public virtual DbSet<gds_schedule_step> gds_schedule_steps { get; set; }

    public virtual DbSet<gds_schedule_time> gds_schedule_times { get; set; }

    public virtual DbSet<general_param> general_params { get; set; }

    public virtual DbSet<gift> gifts { get; set; }

    public virtual DbSet<gift_instance> gift_instances { get; set; }

    public virtual DbSet<group> groups { get; set; }

    public virtual DbSet<group_element> group_elements { get; set; }

    public virtual DbSet<gt_play_session> gt_play_sessions { get; set; }

    public virtual DbSet<gt_playertracking_movement> gt_playertracking_movements { get; set; }

    public virtual DbSet<gt_seat> gt_seats { get; set; }

    public virtual DbSet<gt_sessions_conciliate> gt_sessions_conciliates { get; set; }

    public virtual DbSet<gui_audit> gui_audits { get; set; }

    public virtual DbSet<gui_filter> gui_filters { get; set; }

    public virtual DbSet<gui_form> gui_forms { get; set; }

    public virtual DbSet<gui_profile_form> gui_profile_forms { get; set; }

    public virtual DbSet<gui_user> gui_users { get; set; }

    public virtual DbSet<gui_user_profile> gui_user_profiles { get; set; }

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

    public virtual DbSet<historical_generated_pattern> historical_generated_patterns { get; set; }

    public virtual DbSet<hourly_liability> hourly_liabilities { get; set; }

    public virtual DbSet<hpc_meter> hpc_meters { get; set; }

    public virtual DbSet<identification_type> identification_types { get; set; }

    public virtual DbSet<imported_file> imported_files { get; set; }

    public virtual DbSet<in_house_event> in_house_events { get; set; }

    public virtual DbSet<invalid_play_sessions_to_player_tracking> invalid_play_sessions_to_player_trackings { get; set; }

    public virtual DbSet<lcd_functionality> lcd_functionalities { get; set; }

    public virtual DbSet<lcd_image> lcd_images { get; set; }

    public virtual DbSet<lcd_message> lcd_messages { get; set; }

    public virtual DbSet<licence> licences { get; set; }

    public virtual DbSet<machine_denom_stats_per_hour> machine_denom_stats_per_hours { get; set; }

    public virtual DbSet<machine_meter> machine_meters { get; set; }

    public virtual DbSet<machine_stats_per_hour> machine_stats_per_hours { get; set; }

    public virtual DbSet<mailing_instance> mailing_instances { get; set; }

    public virtual DbSet<mailing_programming> mailing_programmings { get; set; }

    public virtual DbSet<major_prizes_to_generate> major_prizes_to_generates { get; set; }

    public virtual DbSet<mapp_image> mapp_images { get; set; }

    public virtual DbSet<mapp_section_schema> mapp_section_schemas { get; set; }

    public virtual DbSet<mb_movement> mb_movements { get; set; }

    public virtual DbSet<meter> meters { get; set; }

    public virtual DbSet<migration_account1> migration_accounts1 { get; set; }

    public virtual DbSet<migration_play_session> migration_play_sessions { get; set; }

    public virtual DbSet<mobile_bank> mobile_banks { get; set; }

    public virtual DbSet<money_collection> money_collections { get; set; }

    public virtual DbSet<money_collection_detail> money_collection_details { get; set; }

    public virtual DbSet<money_collection_meter> money_collection_meters { get; set; }

    public virtual DbSet<money_meter> money_meters { get; set; }

    public virtual DbSet<monitor_datum> monitor_data { get; set; }

    public virtual DbSet<ms_pending_game_play_session> ms_pending_game_play_sessions { get; set; }

    public virtual DbSet<ms_pending_task68_work_datum> ms_pending_task68_work_data { get; set; }

    public virtual DbSet<ms_site_pending_account> ms_site_pending_accounts { get; set; }

    public virtual DbSet<ms_site_pending_account_document> ms_site_pending_account_documents { get; set; }

    public virtual DbSet<ms_site_pending_account_movement> ms_site_pending_account_movements { get; set; }

    public virtual DbSet<ms_site_pending_last_activity> ms_site_pending_last_activities { get; set; }

    public virtual DbSet<ms_site_synchronize_account> ms_site_synchronize_accounts { get; set; }

    public virtual DbSet<ms_site_task> ms_site_tasks { get; set; }

    public virtual DbSet<multisite_request> multisite_requests { get; set; }

    public virtual DbSet<note_counter> note_counters { get; set; }

    public virtual DbSet<occupancy_sensor> occupancy_sensors { get; set; }

    public virtual DbSet<occupation> occupations { get; set; }

    public virtual DbSet<online_player_tracking> online_player_trackings { get; set; }

    public virtual DbSet<operation_voucher_parameter> operation_voucher_parameters { get; set; }

    public virtual DbSet<operations_after_hour> operations_after_hours { get; set; }

    public virtual DbSet<operations_schedule> operations_schedules { get; set; }

    public virtual DbSet<operations_schedule_status> operations_schedule_statuses { get; set; }

    public virtual DbSet<pattern> patterns { get; set; }

    public virtual DbSet<patterns_information> patterns_informations { get; set; }

    public virtual DbSet<pcd_meters_translation> pcd_meters_translations { get; set; }

    public virtual DbSet<pending_play_sessions_to_player_tracking> pending_play_sessions_to_player_trackings { get; set; }

    public virtual DbSet<pinpad_cashier_terminal> pinpad_cashier_terminals { get; set; }

    public virtual DbSet<pinpad_transaction> pinpad_transactions { get; set; }

    public virtual DbSet<pinpad_transactions_reconciliation> pinpad_transactions_reconciliations { get; set; }

    public virtual DbSet<play> plays { get; set; }

    public virtual DbSet<play_session> play_sessions { get; set; }


    public virtual DbSet<points_to_credit> points_to_credits { get; set; }

    public virtual DbSet<progressife> progressives { get; set; }

    public virtual DbSet<progressives_level> progressives_levels { get; set; }

    public virtual DbSet<progressives_provision> progressives_provisions { get; set; }

    public virtual DbSet<progressives_provisions_level> progressives_provisions_levels { get; set; }

    public virtual DbSet<progressives_provisions_terminal> progressives_provisions_terminals { get; set; }

    public virtual DbSet<promotion> promotions { get; set; }

    public virtual DbSet<promotion_category> promotion_categories { get; set; }

    public virtual DbSet<promotion_flag> promotion_flags { get; set; }

    public virtual DbSet<provider> providers { get; set; }

    public virtual DbSet<providers_bck> providers_bcks { get; set; }

    public virtual DbSet<providers_game> providers_games { get; set; }

    public virtual DbSet<psa_client_daily_report> psa_client_daily_reports { get; set; }

    public virtual DbSet<report> reports { get; set; }

    public virtual DbSet<report_tool_config> report_tool_configs { get; set; }

    public virtual DbSet<reserved_terminal_configuration> reserved_terminal_configurations { get; set; }

    public virtual DbSet<reserved_terminal_transaction> reserved_terminal_transactions { get; set; }

    public virtual DbSet<safe_keeping_account> safe_keeping_accounts { get; set; }

    public virtual DbSet<safe_keeping_operation> safe_keeping_operations { get; set; }

    public virtual DbSet<sales_per_hour> sales_per_hours { get; set; }

    public virtual DbSet<sas_meters_adjustment> sas_meters_adjustments { get; set; }

    public virtual DbSet<sas_meters_catalog> sas_meters_catalogs { get; set; }

    public virtual DbSet<sas_meters_group> sas_meters_groups { get; set; }

    public virtual DbSet<sequence> sequences { get; set; }

    public virtual DbSet<service> services { get; set; }

    public virtual DbSet<service_internet_connection> service_internet_connections { get; set; }

    public virtual DbSet<site> sites { get; set; }

    public virtual DbSet<site_jackpot_instance> site_jackpot_instances { get; set; }

    public virtual DbSet<site_jackpot_parameter> site_jackpot_parameters { get; set; }

    public virtual DbSet<site_service> site_services { get; set; }

    public virtual DbSet<smib_configuration> smib_configurations { get; set; }

    public virtual DbSet<soft_count> soft_counts { get; set; }

    public virtual DbSet<software_validation> software_validations { get; set; }

    public virtual DbSet<sph_control> sph_controls { get; set; }

    public virtual DbSet<stacker> stackers { get; set; }

    public virtual DbSet<terminal> terminals { get; set; }

    public virtual DbSet<terminal_currency> terminal_currencies { get; set; }

    public virtual DbSet<terminal_currency_detail> terminal_currency_details { get; set; }

    public virtual DbSet<terminal_denom_game> terminal_denom_games { get; set; }

    public virtual DbSet<terminal_draws_recharge> terminal_draws_recharges { get; set; }

    public virtual DbSet<terminal_game_translation> terminal_game_translations { get; set; }

    public virtual DbSet<terminal_group> terminal_groups { get; set; }

    public virtual DbSet<terminal_meter_delta_description> terminal_meter_delta_descriptions { get; set; }

    public virtual DbSet<terminal_meter_deltum> terminal_meter_delta { get; set; }

    public virtual DbSet<terminal_money> terminal_moneys { get; set; }

    public virtual DbSet<terminal_sas_meter> terminal_sas_meters { get; set; }

    public virtual DbSet<terminal_sas_meters_history> terminal_sas_meters_histories { get; set; }

    public virtual DbSet<terminal_sas_meters_history_info> terminal_sas_meters_history_infos { get; set; }

    public virtual DbSet<terminal_software_version> terminal_software_versions { get; set; }

    public virtual DbSet<terminal_status> terminal_statuses { get; set; }

    public virtual DbSet<terminal_type> terminal_types { get; set; }

    public virtual DbSet<terminals_3g> terminals_3gs { get; set; }

    public virtual DbSet<terminals_connected> terminals_connecteds { get; set; }

    public virtual DbSet<terminals_pending> terminals_pendings { get; set; }

    public virtual DbSet<terminals_time_disconnected> terminals_time_disconnecteds { get; set; }


    public virtual DbSet<ticket> tickets { get; set; }

    public virtual DbSet<tickets_audit_status_change> tickets_audit_status_changes { get; set; }

    public virtual DbSet<tito_task> tito_tasks { get; set; }

    public virtual DbSet<today_visit> today_visits { get; set; }

    public virtual DbSet<wc2_message> wc2_messages { get; set; }

    public virtual DbSet<wc2_session> wc2_sessions { get; set; }

    public virtual DbSet<wc2_transaction> wc2_transactions { get; set; }

    public virtual DbSet<wcp_command> wcp_commands { get; set; }

    public virtual DbSet<wcp_message> wcp_messages { get; set; }

    public virtual DbSet<wcp_service> wcp_services { get; set; }

    public virtual DbSet<wcp_services_to_cj_queue> wcp_services_to_cj_queues { get; set; }

    public virtual DbSet<wcp_session> wcp_sessions { get; set; }

    public virtual DbSet<wcp_transaction> wcp_transactions { get; set; }

    public virtual DbSet<win_loss_statement> win_loss_statements { get; set; }

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

    public virtual DbSet<wsp_authorized_vendor> wsp_authorized_vendors { get; set; }

    public virtual DbSet<wsp_player_recharge> wsp_player_recharges { get; set; }

    public virtual DbSet<wsp_player_spent_by_day> wsp_player_spent_by_days { get; set; }

    public virtual DbSet<wwp_status> wwp_statuses { get; set; }

    public virtual DbSet<wxp_001_message> wxp_001_messages { get; set; }

    public virtual DbSet<wxp_002_message> wxp_002_messages { get; set; }

    public virtual DbSet<wxp_parameter> wxp_parameters { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=WG-501-B;Database=wgdb_000;User Id=wg_datareaderMeier1;Password=NH,!se%-nHo_7=Pjy)zJ;Trusted_Connection=false; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Card_Generation>(entity =>
        {
            entity.Property(e => e.cg_site_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ErrorHandling>(entity =>
        {
            entity.HasKey(e => e.pkErrorHandlingID).HasName("PK__ErrorHan__520223CB76976885");
        });

        modelBuilder.Entity<MIGRATION_ACCOUNT>(entity =>
        {
            entity.Property(e => e.SOURCE_ACCOUNT_ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<PROVIDERS_GAMES_FINALLY>(entity =>
        {
            entity.Property(e => e.PG_GAME_ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Resultado_fragment>(entity =>
        {
            entity.Property(e => e.Clust).UseCollation("Latin1_General_CI_AS_KS_WS");
        });

        modelBuilder.Entity<SAVED_CHANGE_POINT>(entity =>
        {
            entity.Property(e => e.AM_MOVEMENT_ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SAVED_EXPIRED_CREDITS_AM>(entity =>
        {
            entity.Property(e => e.am_movement_id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SAVED_EXPIRED_CREDITS_CM>(entity =>
        {
            entity.Property(e => e.cm_movement_id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TABLESFRAGMENT>(entity =>
        {
            entity.Property(e => e.Clust).UseCollation("Latin1_General_CI_AS_KS_WS");
        });

        modelBuilder.Entity<TMP_TERMINALS_TO_BASE_NAME>(entity =>
        {
            entity.Property(e => e.te_terminal_id).ValueGeneratedOnAdd();
            entity.Property(e => e.te_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Temp_account_point>(entity =>
        {
            entity.Property(e => e.AccountId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UNDO_PIN_PAD_TRANSACTION>(entity =>
        {
            entity.HasKey(e => e.uppt_id).HasName("PK_upp_id");
        });
        modelBuilder.Entity<account>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("InHouseAPI_Accounts_Updated");
                    tb.HasTrigger("MultiSiteTrigger_SiteAccountUpdate");
                    tb.HasTrigger("TRIGGER_PIN_FAILED");
                });

            entity.Property(e => e.ac_account_id).ValueGeneratedNever();
            entity.Property(e => e.ac_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<account_document>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("MultiSiteTrigger_SiteAccountDocuments"));

            entity.Property(e => e.ad_account_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<account_flag>(entity =>
        {

        });

        modelBuilder.Entity<account_major_prize>(entity =>
        {
            entity.Property(e => e.amp_operation_id).ValueGeneratedNever();


        });

        modelBuilder.Entity<account_movement>(entity =>
        {
            entity.HasKey(e => e.am_movement_id).HasName("PK_movements");

            entity.ToTable(tb => tb.HasTrigger("Trigger_SiteToMultiSite_Points"));


        });

        modelBuilder.Entity<account_payment_order>(entity =>
        {
            entity.HasKey(e => e.apo_operation_id).HasName("PK_account_payment_order");

            entity.Property(e => e.apo_operation_id).ValueGeneratedNever();


        });

        modelBuilder.Entity<account_photo>(entity =>
        {
            entity.ToTable("account_photo", tb => tb.HasTrigger("InHouseAPI_Photo_Updated"));

            entity.Property(e => e.aph_account_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<account_points_cache>(entity =>
        {
            entity.Property(e => e.apc_account_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<account_points_expired_list>(entity =>
        {
            entity.Property(e => e.apel_account_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<afip_log>(entity =>
        {
            entity.HasKey(e => e.afl_id).HasName("PK_AFIP_LOG");
        });

        modelBuilder.Entity<alarm>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("Trigger_Alarms_Buffer_ETL"));

            entity.Property(e => e.al_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
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


        modelBuilder.Entity<area>(entity =>
        {
            entity.Property(e => e.ar_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<audit_3g>(entity =>
        {
            entity.Property(e => e.a3gs_id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<bank>(entity =>
        {
            entity.Property(e => e.bk_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

        });

        modelBuilder.Entity<bank_transaction>(entity =>
        {
            entity.Property(e => e.bt_operation_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<blacklist_file_imported>(entity =>
        {
            entity.Property(e => e.blkf_id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<blacklist_file_imported_type>(entity =>
        {
            entity.HasKey(e => e.bklt_id_type).HasName("PK__blacklis__DEE9EDAE7B1C2680");
        });

        modelBuilder.Entity<bucket>(entity =>
        {
            entity.Property(e => e.bu_bucket_id).ValueGeneratedNever();
            entity.Property(e => e.bu_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<buckets_multiplier_schedule>(entity =>
        {
            entity.Property(e => e.bm_bucket_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<buffer_terminals_time_disconnected>(entity =>
        {
            entity.HasKey(e => new { e.bttd_site_id, e.bttd_terminal_id, e.bttd_working_day }).HasName("PK_bttd_id");
        });

        modelBuilder.Entity<c2_draw_audit>(entity =>
        {
            entity.HasKey(e => e.da_draw_id).HasName("PK_draw_audit");
        });

        modelBuilder.Entity<c2_draw_audit_play>(entity =>
        {
            entity.HasKey(e => e.dap_play_id).HasName("PK_Draw_Audit_Plays");


        });


        modelBuilder.Entity<c2_jackpot_counter>(entity =>
        {
            entity.Property(e => e.c2jc_index).ValueGeneratedNever();


        });

        modelBuilder.Entity<c2_jackpot_history>(entity =>
        {

        });

        modelBuilder.Entity<c2_jackpot_instance>(entity =>
        {
            entity.Property(e => e.c2ji_index).ValueGeneratedNever();
            entity.Property(e => e.c2ji_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<c2_jackpot_parameter>(entity =>
        {
            entity.Property(e => e.c2jp_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<c2_winning_pattern>(entity =>
        {
            entity.Property(e => e.w2p_pattern_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<cage_concept>(entity =>
        {
            entity.Property(e => e.cc_concept_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<cage_movement>(entity =>
        {
            entity.HasKey(e => e.cgm_movement_id).HasName("PK_CAGE_MOVEMENTS");


        });

        modelBuilder.Entity<cage_movement_detail>(entity =>
        {
            entity.HasKey(e => e.cmd_cage_movement_detail_id).HasName("PK_CAGE_MOVEMENT_DETAIL");


        });

        modelBuilder.Entity<cage_pending_movement>(entity =>
        {
            entity.HasKey(e => e.cpm_movement_id).HasName("PK_CAGE_PENDING_MOVEMENT");

            entity.Property(e => e.cpm_movement_id).ValueGeneratedNever();

        });

        modelBuilder.Entity<cage_session>(entity =>
        {
            entity.HasKey(e => e.cgs_cage_session_id).HasName("PK_CAGE_SESSIONS");
        });

        modelBuilder.Entity<cage_source_target>(entity =>
        {
            entity.HasKey(e => e.cst_source_target_id).HasName("PK_CAGE_SOURCE_TARGET");

            entity.Property(e => e.cst_source_target_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<card>(entity =>
        {
            entity.Property(e => e.ca_trackdata).IsFixedLength();
            entity.Property(e => e.ca_pin).IsFixedLength();
        });

        modelBuilder.Entity<cashier_movement>(entity =>
        {

        });

        modelBuilder.Entity<cashier_movements_grouped_by_hour>(entity =>
        {
            entity.HasKey(e => new { e.CM_DATE, e.CM_TYPE, e.CM_SUB_TYPE, e.CM_CURRENCY_ISO_CODE, e.CM_CAGE_CURRENCY_TYPE, e.CM_CURRENCY_DENOMINATION }).HasName("PK_CASHIER_MOVEMENTS_GROUPED_BY_HOUR");

            entity.Property(e => e.cm_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.cm_unique_id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<cashier_movements_grouped_by_session_id>(entity =>
        {
            entity.HasKey(e => new { e.CM_SESSION_ID, e.CM_TYPE, e.CM_SUB_TYPE, e.CM_CURRENCY_ISO_CODE, e.CM_CAGE_CURRENCY_TYPE, e.CM_CURRENCY_DENOMINATION }).HasName("PK_CASHIER_MOVEMENTS_GROUPED_BY_SESSION_ID");
        });

        modelBuilder.Entity<cashier_movements_pending_history>(entity =>
        {
            entity.HasKey(e => new { e.cmph_movement_id, e.cmph_sub_type }).HasName("pk_cashier_movements_pending_history");
        });

        modelBuilder.Entity<cashier_voucher>(entity =>
        {

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
        });

        modelBuilder.Entity<cj_transaction>(entity =>
        {
            entity.Property(e => e.ctx_status).HasComment("0 - Running, 1 - Finished");

        });

        modelBuilder.Entity<closing_stock>(entity =>
        {
            entity.Property(e => e.cs_cashier_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<countr>(entity =>
        {
            entity.HasKey(e => e.cr_countr_id).HasName("PK_cr_countr_id");
        });

        modelBuilder.Entity<countr_log>(entity =>
        {
            entity.HasKey(e => e.crl_id).HasName("PK_crl_id");
        });

        modelBuilder.Entity<countr_session>(entity =>
        {
            entity.HasKey(e => e.crs_session_id).HasName("PK_crs_session_id");
        });

        modelBuilder.Entity<credit_line>(entity =>
        {
            entity.HasKey(e => e.cl_id).HasName("PK_cl_id");

            entity.Property(e => e.cl_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<credit_line_movement>(entity =>
        {
            entity.HasKey(e => e.clm_id).HasName("PK_clm_id");

            entity.Property(e => e.clm_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<currency_denomination>(entity =>
        {

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
            entity.Property(e => e.cue_coupon).IsFixedLength();
        });

        modelBuilder.Entity<customer_entrances_price>(entity =>
        {
            entity.HasKey(e => e.cuep_price_id).HasName("PK_Customer_Entrances_Prices");
        });

        modelBuilder.Entity<customer_notice>(entity =>
        {
            entity.Property(e => e.cn_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<customer_visit>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("InHouseAPI_Customer_Visits_Insert"));
        });

        modelBuilder.Entity<db_user>(entity =>
        {
            entity.Property(e => e.du_password).IsFixedLength();
        });

        modelBuilder.Entity<deleted_account>(entity =>
        {
            entity.Property(e => e.ac_account_id).ValueGeneratedOnAdd();
            entity.Property(e => e.ac_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<draw_ticket>(entity =>
        {
            entity.Property(e => e.dt_id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<elp01_space_request>(entity =>
        {
            entity.Property(e => e.es_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<event_history>(entity =>
        {
            entity.Property(e => e.eh_event_id).ValueGeneratedOnAdd();
            entity.Property(e => e.eh_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();


        });

        modelBuilder.Entity<external_validation_operation>(entity =>
        {
            entity.HasKey(e => e.evo_id).HasName("PK_EXTERNAL_VALIDATION_OPERATION");
        });

        modelBuilder.Entity<fbm_log>(entity =>
        {
            entity.HasKey(e => e.fl_id).HasName("PK_fl_id");
        });

        modelBuilder.Entity<game>(entity =>
        {
            entity.Property(e => e.gm_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<game_meter>(entity =>
        {

        });

        modelBuilder.Entity<gamegateway_bet>(entity =>
        {
            entity.HasKey(e => new { e.gb_game_id, e.gb_game_instance_id, e.gb_partner_id, e.gb_transaction_type, e.gb_transaction_id, e.gb_account_id }).HasName("PK_gamegateway_bets_1");

            entity.Property(e => e.gb_last_updated)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<gamegateway_command_message>(entity =>
        {
            entity.HasKey(e => e.gcm_id).HasName("pk_gamegateway_command_messages");
        });

        modelBuilder.Entity<gamegateway_game>(entity =>
        {
            entity.Property(e => e.gg_last_updated)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<gamegateway_game_instance>(entity =>
        {
            entity.Property(e => e.ggi_last_updated)
                .IsRowVersion()
                .IsConcurrencyToken();
        });





        modelBuilder.Entity<gaming_table>(entity =>
        {
            entity.HasKey(e => e.gt_gaming_table_id).HasName("pk_gaming_tables");

            entity.Property(e => e.gt_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();


        });

        modelBuilder.Entity<gaming_tables_connected>(entity =>
        {
            entity.HasKey(e => new { e.gmc_gamingtable_id, e.gmc_gaming_day }).HasName("PK_Gaming_Tables_Connected");
        });

        modelBuilder.Entity<gaming_tables_type>(entity =>
        {
            entity.HasKey(e => e.gtt_gaming_table_type_id).HasName("pk_gaming_tables_types");
        });

        modelBuilder.Entity<gds_group>(entity =>
        {
            entity.Property(e => e.gg_group_is_explicit).HasComment("0 - Group defined through SQL definition; 1 - Group defined by explicit assignment");
        });

        modelBuilder.Entity<gds_group_element>(entity =>
        {
            entity.Property(e => e.gge_is_group).HasComment("0 - Single Element; 1 - Group Definition");

        });

        modelBuilder.Entity<gds_platform>(entity =>
        {
            entity.Property(e => e.gp_platform_id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<gds_schedule_step>(entity =>
        {

        });

        modelBuilder.Entity<gds_schedule_time>(entity =>
        {
            entity.HasKey(e => e.gst_schedule_id).HasName("PK_gst_schedule_time");

            entity.Property(e => e.gst_recurrence).HasComment("0 - One time; 1 - Daily; 2 - Week Days; 3 - Weekends; 4 - Weekly");
        });

        modelBuilder.Entity<group_element>(entity =>
        {

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
        });

        modelBuilder.Entity<gui_audit>(entity =>
        {
        });

        modelBuilder.Entity<gui_profile_form>(entity =>
        {
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
            entity.ToTable(tb => tb.HasTrigger("Trigger_Handpays_Buffer_ETL"));

            entity.Property(e => e.HP_TIMESTAMP)
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
        });

        modelBuilder.Entity<invalid_play_sessions_to_player_tracking>(entity =>
        {
            entity.Property(e => e.ips_unique_ud).ValueGeneratedOnAdd();
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
        });

        modelBuilder.Entity<lcd_message>(entity =>
        {
            entity.Property(e => e.msg_unique_id).ValueGeneratedNever();
            entity.Property(e => e.msg_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<licence>(entity =>
        {
            entity.Property(e => e.wl_id).ValueGeneratedOnAdd();
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

        modelBuilder.Entity<mailing_instance>(entity =>
        {
            entity.Property(e => e.mi_prog_data).HasComment("Time in minutes (0..1439)");
            entity.Property(e => e.mi_status).HasComment("0: Pending; 1: Running; 2: Successful; 3: Failed");
            entity.Property(e => e.mi_type).HasComment("1: Statistics");
        });

        modelBuilder.Entity<mailing_programming>(entity =>
        {
            entity.HasKey(e => e.mp_prog_id).HasName("PK_mailing_scheduling");

            entity.Property(e => e.mp_schedule_time_from).HasComment("Time in minutes (0..1439)");
            entity.Property(e => e.mp_schedule_time_to).HasComment("Time in minutes (0..1439)");
            entity.Property(e => e.mp_type).HasComment("1: Statistics");
        });

        modelBuilder.Entity<major_prizes_to_generate>(entity =>
        {
            entity.Property(e => e.mpg_operation_id).ValueGeneratedNever();

        });

        modelBuilder.Entity<mapp_image>(entity =>
        {
            entity.HasKey(e => e.im_image_id).HasName("PK_Image");
        });

        modelBuilder.Entity<mapp_section_schema>(entity =>
        {
            entity.HasKey(e => e.ss_section_schema_id).HasName("PK_SectionSchema");

        });

        modelBuilder.Entity<meter>(entity =>
        {
            entity.Property(e => e.me_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

        });

        modelBuilder.Entity<migration_account1>(entity =>
        {
            entity.Property(e => e.ac_account_id).ValueGeneratedOnAdd();
            entity.Property(e => e.ac_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<migration_play_session>(entity =>
        {
            entity.Property(e => e.ps_play_session_id).ValueGeneratedOnAdd();
            entity.Property(e => e.ps_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<mobile_bank>(entity =>
        {
            entity.HasKey(e => e.mb_account_id).HasName("PK_mobile_bank");

            entity.Property(e => e.mb_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<money_collection>(entity =>
        {
            entity.HasIndex(e => e.mc_collection_datetime, "IX_mc_collection_datetime").HasFillFactor(90);
        });

        modelBuilder.Entity<money_collection_meter>(entity =>
        {
            entity.Property(e => e.mcm_session_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<money_meter>(entity =>
        {
            entity.Property(e => e.mm_cash_type).HasComment("1-CashIn, 2-CashOut");
            entity.Property(e => e.mm_money_type).HasComment("1-Note, 2-Coin");
            entity.Property(e => e.mm_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

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

        modelBuilder.Entity<ms_site_pending_last_activity>(entity =>
        {
            entity.Property(e => e.laa_account_id).ValueGeneratedNever();
            entity.Property(e => e.laa_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ms_site_task>(entity =>
        {
            entity.HasKey(e => e.st_task_id).HasName("PK_ms_site_synch_control");

            entity.Property(e => e.st_task_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<note_counter>(entity =>
        {
            entity.Property(e => e.nc_application_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<occupancy_sensor>(entity =>
        {
            entity.HasKey(e => e.ose_id).HasName("PK_sensor_inout");
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

        modelBuilder.Entity<pending_play_sessions_to_player_tracking>(entity =>
        {
            entity.Property(e => e.pps_session_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<pinpad_cashier_terminal>(entity =>
        {
            entity.HasKey(e => e.pct_id).HasName("PK_pct_id");
        });

        modelBuilder.Entity<pinpad_transaction>(entity =>
        {
            entity.HasKey(e => e.pt_id).HasName("PK_pt_id");
        });

        modelBuilder.Entity<play>(entity =>
        {
        });

        modelBuilder.Entity<play_session>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("InHouseAPI_Play_Sessions_Insert"));

            entity.Property(e => e.ps_status).HasComment("0-Opened; 1-Closed; 2-Abandoned");
            entity.Property(e => e.ps_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

        });


        modelBuilder.Entity<promotion_flag>(entity =>
        {
        });

        modelBuilder.Entity<provider>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("ProviderTerminalTrigger"));

            entity.Property(e => e.pv_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<providers_game>(entity =>
        {
            entity.Property(e => e.pg_game_id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<report_tool_config>(entity =>
        {
            entity.HasKey(e => e.rtc_report_tool_id).HasName("PK__report_t__91E6C95D13B2CA20");
        });

        modelBuilder.Entity<reserved_terminal_configuration>(entity =>
        {
            entity.HasKey(e => e.rtc_holder_level).HasName("pk_reserved_terminal_configuration");

            entity.Property(e => e.rtc_holder_level).ValueGeneratedNever();
        });

        modelBuilder.Entity<reserved_terminal_transaction>(entity =>
        {
            entity.HasKey(e => e.rtt_transaction_id).HasName("PK__reserved__BABB3A3812748D24");

        });

        modelBuilder.Entity<sales_per_hour>(entity =>
        {
            entity.Property(e => e.sph_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.sph_unique_id).ValueGeneratedOnAdd();
        });


        modelBuilder.Entity<sas_meters_adjustment>(entity =>
        {
            entity.Property(e => e.tma_unique_id).ValueGeneratedOnAdd();
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

        modelBuilder.Entity<service_internet_connection>(entity =>
        {
            entity.Property(e => e.sic_protocol).IsFixedLength();
        });

        modelBuilder.Entity<site>(entity =>
        {
            entity.Property(e => e.st_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<site_jackpot_instance>(entity =>
        {
            entity.Property(e => e.sji_index).ValueGeneratedNever();
        });

        modelBuilder.Entity<site_service>(entity =>
        {
            entity.Property(e => e.ss_id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<sph_control>(entity =>
        {
            entity.Property(e => e.sphc_last_play_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<stacker>(entity =>
        {
            entity.Property(e => e.st_stacker_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<terminal>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("TerminalProviderTrigger");
                    tb.HasTrigger("TriggerValidateRegistrationCode");
                });

            entity.Property(e => e.te_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

        });

        modelBuilder.Entity<terminal_denom_game>(entity =>
        {
            entity.Property(e => e.tdg_terminal_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<terminal_draws_recharge>(entity =>
        {
            entity.HasKey(e => e.tdr_id).HasName("PK_tdr_id");
        });

        modelBuilder.Entity<terminal_game_translation>(entity =>
        {
            entity.Property(e => e.tgt_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<terminal_sas_meter>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("Trigger_TSM_Buffer_ETL"));
        });

        modelBuilder.Entity<terminal_sas_meters_history>(entity =>
        {
            entity.ToTable("terminal_sas_meters_history", tb => tb.HasTrigger("Trigger_TSMH_Buffer_ETL"));
        });

        modelBuilder.Entity<terminal_software_version>(entity =>
        {
            entity.HasKey(e => new { e.tsv_client_id, e.tsv_build_id, e.tsv_terminal_type }).HasName("PK_kiosk_software_versions");
        });

        modelBuilder.Entity<terminal_status>(entity =>
        {
            entity.Property(e => e.ts_terminal_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<terminal_type>(entity =>
        {
            entity.Property(e => e.tt_type).ValueGeneratedNever();
            entity.Property(e => e.tt_name).IsFixedLength();
        });

        modelBuilder.Entity<terminals_connected>(entity =>
        {
            entity.ToTable("terminals_connected", tb => tb.HasTrigger("Trigger_ttc_buffer_ETL"));

            entity.Property(e => e.tc_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<terminals_time_disconnected>(entity =>
        {
            entity.HasKey(e => new { e.ttd_site_id, e.ttd_terminal_id, e.ttd_working_day }).HasName("PK_ttd_id");

            entity.ToTable("terminals_time_disconnected", tb => tb.HasTrigger("Trigger_ttd_buffer_ETL"));
        });

        modelBuilder.Entity<ticket>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("Trigger_Audit_TicketStatusChange"));
        });

        modelBuilder.Entity<tickets_audit_status_change>(entity =>
        {
            entity.HasKey(e => new { e.tia_id, e.tia_validation_number }).HasName("PK_tickets_audit");

            entity.Property(e => e.tia_id).ValueGeneratedOnAdd();
        });


        modelBuilder.Entity<wc2_message>(entity =>
        {
        });

        modelBuilder.Entity<wc2_session>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("Trigger_wc2_sessions_Buffer_ETL"));

            entity.Property(e => e.w2s_status).HasComment("0 - Opened, 1 - Closed, 2 - Abandoned, 3 - Timeout");
            entity.Property(e => e.w2s_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

        });

        modelBuilder.Entity<wc2_transaction>(entity =>
        {
            entity.Property(e => e.w2tx_status).HasComment("0 - Running, 1 - Finished");

        });

        modelBuilder.Entity<wcp_command>(entity =>
        {
            entity.HasIndex(e => e.cmd_created, "IX_wcp_cmd_created").HasFillFactor(90);
        });

        modelBuilder.Entity<wcp_message>(entity =>
        {

        });

        modelBuilder.Entity<wcp_services_to_cj_queue>(entity =>
        {
            entity.HasKey(e => e.wscq_service_id).HasName("PK_wcp_services_to_cj_queues_1");

            entity.Property(e => e.wscq_service_id).ValueGeneratedNever();

        });

        modelBuilder.Entity<wcp_session>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("Trigger_wcp_sessions_Buffer_ETL"));

            entity.Property(e => e.ws_status).HasComment("0 - Opened, 1 - Closed, 2 - Abandoned, 3 - Timeout");
            entity.Property(e => e.ws_timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

        });

        modelBuilder.Entity<wcp_transaction>(entity =>
        {
            entity.Property(e => e.wtx_status).HasComment("0 - Running, 1 - Finished");

        });

        modelBuilder.Entity<wkt_ad>(entity =>
        {
            entity.HasKey(e => e.ad_id).HasName("PK_WKT_Ads");
        });

        modelBuilder.Entity<wkt_ad_step>(entity =>
        {
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

        modelBuilder.Entity<wkt_resource>(entity =>
        {
            entity.HasKey(e => e.res_resource_id).HasName("PK_WKT_Resources");
        });

        modelBuilder.Entity<wsp_player_recharge>(entity =>
        {
            entity.Property(e => e.wpr_status).HasComment("1 - Pending; 2 - In Progress; 3 - Error; 4 - Ok; 5 - Timeout");
        });

        modelBuilder.Entity<wwp_status>(entity =>
        {
            entity.Property(e => e.wwp_type).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
