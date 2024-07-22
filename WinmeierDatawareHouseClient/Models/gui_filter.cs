using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("gf_user_id", "gf_form_id")]
public partial class gui_filter
{
    [Key]
    public int gf_user_id { get; set; }

    [Key]
    public int gf_form_id { get; set; }

    [Column(TypeName = "xml")]
    public string gf_filter { get; set; } = null!;
}
