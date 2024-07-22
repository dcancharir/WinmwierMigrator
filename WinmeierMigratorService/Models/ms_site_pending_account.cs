using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class ms_site_pending_account
{
    [Key]
    public long spa_account_id { get; set; }

    public Guid? spa_guid { get; set; }
}
