using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class document
{
    public long doc_document_id { get; set; }

    public int doc_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime doc_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime doc_modified { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? doc_printed { get; set; }

    [MaxLength(1)]
    public byte[]? doc_data { get; set; }
}
