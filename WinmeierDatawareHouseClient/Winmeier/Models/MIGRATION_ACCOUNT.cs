using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Table("MIGRATION.ACCOUNTS")]
public partial class MIGRATION_ACCOUNT
{
    [Key]
    public long SOURCE_ACCOUNT_ID { get; set; }

    public long TARGET_ACCOUNT_ID { get; set; }

    public int? STATUS { get; set; }
}
