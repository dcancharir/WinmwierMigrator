using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("jtdm_doc_type", "jtdm_pdf_key")]
[Table("jackpot_tax_document_mapper")]
public partial class jackpot_tax_document_mapper
{
    [Key]
    public int jtdm_doc_type { get; set; }

    [Key]
    [StringLength(200)]
    public string jtdm_pdf_key { get; set; } = null!;

    [StringLength(200)]
    public string jtdm_wigos_key { get; set; } = null!;

    public int jtdm_year { get; set; }
}
