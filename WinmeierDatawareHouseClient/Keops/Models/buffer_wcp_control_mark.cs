using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("buffer_wcp_control_mark")]
public partial class buffer_wcp_control_mark
{
    public long wcm_control_mark { get; set; }
}
