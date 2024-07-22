using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Table("terminal_status")]
public partial class terminal_status
{
    [Key]
    public int ts_terminal_id { get; set; }

    public bool ts_sas_host_error { get; set; }

    [Column(TypeName = "money")]
    public decimal? ts_current_payout { get; set; }

    public int ts_stacker_counter { get; set; }

    public int ts_stacker_status { get; set; }

    public int ts_egm_flags { get; set; }

    public int ts_door_flags { get; set; }

    public int ts_bill_flags { get; set; }

    public int ts_printer_flags { get; set; }

    public int ts_played_won_flags { get; set; }

    public int ts_jackpot_flags { get; set; }

    public bool ts_call_attendant_flags { get; set; }

    public int ts_machine_flags { get; set; }

    public long? ts_played_alarm_id { get; set; }

    public long? ts_won_alarm_id { get; set; }

    public long? ts_jackpot_alarm_id { get; set; }

    public long? ts_canceled_credit_alarm_id { get; set; }

    public long? ts_counterfeit_alarm_id { get; set; }

    public long? ts_without_plays_alarm_id { get; set; }

    public long? ts_current_payout_alarm_id { get; set; }

    public int ts_coin_flags { get; set; }

    public long? ts_highroller_alarm_id { get; set; }

    public long? ts_highroller_anonymous_alarm_id { get; set; }

    public bool? ts_is_reserved { get; set; }
}
