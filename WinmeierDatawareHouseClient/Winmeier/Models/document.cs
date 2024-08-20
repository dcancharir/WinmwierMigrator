using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

public partial class document
{
    [Key]
    public long doc_document_id { get; set; }

    public int doc_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime doc_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime doc_modified { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? doc_printed { get; set; }

    public byte[]? doc_data { get; set; }
}
