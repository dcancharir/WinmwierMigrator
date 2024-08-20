using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class ms_site_pending_account_movement
{
    [Key]
    public long spm_movement_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? SPM_ADD_AMOUNT { get; set; }

    [Column(TypeName = "money")]
    public decimal? SPM_SUB_AMOUNT { get; set; }

    public int? SPM_TYPE { get; set; }

    public long? SPM_ACCOUNT_ID { get; set; }
}
