using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Keyless]
[Index("gge_group_id", "gge_is_group", "gge_element_id", Name = "IX_gds_group_elements", IsUnique = true)]
public partial class gds_group_element
{
    public long gge_group_id { get; set; }

    /// <summary>
    /// 0 - Single Element; 1 - Group Definition
    /// </summary>
    public bool gge_is_group { get; set; }

    public long gge_element_id { get; set; }
}
