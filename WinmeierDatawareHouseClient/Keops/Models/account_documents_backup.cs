using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("account_documents_backup")]
public partial class account_documents_backup
{
    public long ad_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ad_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ad_modified { get; set; }

    public byte[]? ad_data { get; set; }

    public long? ad_ms_sequence_id { get; set; }
}
