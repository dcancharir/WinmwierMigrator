using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("account_points_expired_list")]
public partial class account_points_expired_list
{
    [Key]
    public long apel_account_id { get; set; }

    [Column(TypeName = "money")]
    public decimal apel_points_to_expire { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime apel_datetime { get; set; }
}
