using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("field_validator")]
public partial class field_validator
{
    public long fv_field_id { get; set; }

    public int fv_origin_type { get; set; }

    public long fv_origin_reference_id { get; set; }

    public int fv_type_field { get; set; }

    public int fv_current_status { get; set; }

    public string? fv_current_status_description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fv_last_update { get; set; }
}
