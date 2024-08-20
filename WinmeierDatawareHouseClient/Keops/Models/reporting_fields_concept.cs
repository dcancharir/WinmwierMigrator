using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class reporting_fields_concept
{
    public long rfc_field_id { get; set; }

    public int? rfc_sourcetarget_id { get; set; }

    public int? rfc_concept_id { get; set; }

    [Column(TypeName = "money")]
    public decimal rfc_default_value { get; set; }
}
