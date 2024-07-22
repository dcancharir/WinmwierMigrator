using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("ed_working_day", "ed_site_id")]
[Table("egm_daily")]
[Index("ed_working_day", "ed_site_id", Name = "IX_ed_workingday_site", IsUnique = true)]
public partial class egm_daily
{
    [Key]
    public int ed_working_day { get; set; }

    [Key]
    public int ed_site_id { get; set; }

    public byte ed_status { get; set; }

    public bool ed_has_new_meters { get; set; }

    public int ed_terminals_connected { get; set; }

    public int ed_terminals_number { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ed_last_updated_meters { get; set; }

    public int? ed_last_updated_user { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ed_last_updated_user_datetime { get; set; }
}
