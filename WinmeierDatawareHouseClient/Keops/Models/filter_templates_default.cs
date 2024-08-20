using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("filter_templates_default")]
public partial class filter_templates_default
{
    public long ftd_filter_templates_default_id { get; set; }

    public long ftd_filter_template_id { get; set; }

    public int ftd_user_id { get; set; }

    public bool ftd_default { get; set; }
}
