using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class terminal_meter_deltum
{
    [Key]
    public long tmd_id { get; set; }

    [StringLength(50)]
    public string? tmd_description { get; set; }

    public long? tmd_sas_meter_big_inc_cents_bill_in { get; set; }

    public long? tmd_sas_meter_big_inc_cents_ft_from_egm { get; set; }

    public long? tmd_sas_meter_big_inc_cents_ft_to_egm { get; set; }

    public long? tmd_sas_meter_big_inc_cents_handpays { get; set; }

    public long? tmd_sas_meter_big_inc_cents_jackpot { get; set; }

    public long? tmd_sas_meter_big_inc_cents_played { get; set; }

    public long? tmd_sas_meter_big_inc_cents_ticket_in { get; set; }

    public long? tmd_sas_meter_big_inc_cents_ticket_out { get; set; }

    public long? tmd_sas_meter_big_inc_cents_won { get; set; }

    public long? tmd_sas_meter_big_inc_quantity_bill_in { get; set; }

    public long? tmd_sas_meter_big_inc_quantity_ft_from_egm { get; set; }

    public long? tmd_sas_meter_big_inc_quantity_ft_to_egm { get; set; }

    public long? tmd_sas_meter_big_inc_quantity_games_played { get; set; }

    public long? tmd_sas_meter_big_inc_quantity_games_won { get; set; }

    public long? tmd_sas_meter_big_inc_quantity_ticket_in { get; set; }

    public long? tmd_sas_meter_big_inc_quantity_ticket_out { get; set; }

    public long tmd_sas_meter_big_inc_cents_coin_acceptor { get; set; }
}
