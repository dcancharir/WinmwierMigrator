using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Keyless]
[Table("SAVED_CHANGE_POINTS")]
public partial class SAVED_CHANGE_POINT
{
    public long AM_MOVEMENT_ID { get; set; }

    public long AM_ACCOUNT_ID { get; set; }

    public int AM_TYPE { get; set; }

    [Column(TypeName = "money")]
    public decimal AM_INITIAL_BALANCE { get; set; }

    [Column(TypeName = "money")]
    public decimal AM_ADD_AMOUNT { get; set; }

    [Column(TypeName = "money")]
    public decimal AM_SUB_AMOUNT { get; set; }

    [Column(TypeName = "money")]
    public decimal AM_FINAL_BALANCE { get; set; }
}
