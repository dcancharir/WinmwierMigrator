using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class account_document
{
    [Key]
    public long ad_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ad_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ad_modified { get; set; }

    public byte[]? ad_data { get; set; }

    public long? ad_ms_sequence_id { get; set; }
}
