using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("egm_control_mark")]
public partial class egm_control_mark
{
    [Key]
    public int ecm_site_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ecm_control_mark { get; set; }
}
