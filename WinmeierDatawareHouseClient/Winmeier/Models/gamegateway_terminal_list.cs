using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Keyless]
[Table("gamegateway_terminal_list")]
public partial class gamegateway_terminal_list
{
    [Column(TypeName = "xml")]
    public string? gtl_terminal_list { get; set; }
}
