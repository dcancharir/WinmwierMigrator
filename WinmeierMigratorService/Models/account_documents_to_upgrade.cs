using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
[Table("account_documents_to_upgrade")]
public partial class account_documents_to_upgrade
{
    public long AC_ACCOUNT_ID { get; set; }

    [StringLength(50)]
    public string AC_HOLDER_ID3_TYPE { get; set; } = null!;

    [StringLength(50)]
    public string AC_BENEFICIARY_ID3_TYPE { get; set; } = null!;
}
