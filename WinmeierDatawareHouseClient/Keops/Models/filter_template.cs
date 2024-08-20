using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class filter_template
{
    public long ft_filter_template_id { get; set; }

    [StringLength(200)]
    public string ft_name { get; set; } = null!;

    [StringLength(400)]
    public string? ft_description { get; set; }

    public int ft_form_id { get; set; }

    public int ft_form_mode { get; set; }

    public bool ft_generic { get; set; }

    public int? ft_owner { get; set; }

    [Column(TypeName = "xml")]
    public string? ft_filter { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ft_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ft_last_updated { get; set; }
}
