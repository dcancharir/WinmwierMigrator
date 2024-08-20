using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("jackpot_tax_document_mapper_bkp_2022_03")]
public partial class jackpot_tax_document_mapper_bkp_2022_03
{
    public int jtdm_doc_type { get; set; }

    [StringLength(200)]
    public string jtdm_pdf_key { get; set; } = null!;

    [StringLength(200)]
    public string jtdm_wigos_key { get; set; } = null!;

    public int jtdm_year { get; set; }
}
