using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("cage_vault")]
public partial class cage_vault
{
    public int CGVA_ID { get; set; }

    [StringLength(300)]
    public string CGVA_NAME { get; set; } = null!;

    [Column(TypeName = "text")]
    public string CGVA_DESCRIPTION { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CGVA_CREATED { get; set; }

    public bool? CGVA_DEFAULT { get; set; }
}
