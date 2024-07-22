using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class hourly_liability
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime hlb_datetime { get; set; }

    [Column(TypeName = "money")]
    public decimal hlb_re_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal hlb_promo_re_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal hlb_promo_nr_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal hlb_in_session_re_to_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal hlb_in_session_promo_re_to_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal hlb_in_session_promo_nr_to_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal hlb_points { get; set; }

    public int hlb_num_accounts { get; set; }

    public int hlb_num_accounts_in_session { get; set; }
}
