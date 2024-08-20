using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("raa_alarm_code", "raa_date_time")]
[Index("raa_account_id", "raa_alarm_code", Name = "IDX_raa_accountId_alarmCode", IsUnique = true)]
public partial class recent_account_alarm
{
    [Key]
    public int raa_alarm_code { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime raa_date_time { get; set; }

    public long raa_account_id { get; set; }

    public long raa_alarm_id { get; set; }
}
