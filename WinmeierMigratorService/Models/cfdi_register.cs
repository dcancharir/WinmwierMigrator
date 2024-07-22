using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("cr_operation_id", "cr_status", Name = "IX_operation_id_status")]
public partial class cfdi_register
{
    [Key]
    public long cr_operation_id { get; set; }

    public int cr_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cr_inserted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cr_updated { get; set; }

    [Column(TypeName = "xml")]
    public string cr_xml_request { get; set; } = null!;

    public int? cr_retries { get; set; }

    public int? cr_error_code { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? cr_error_message { get; set; }

    [Column(TypeName = "text")]
    public string? cr_reported_data { get; set; }
}
