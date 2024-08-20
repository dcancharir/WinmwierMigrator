using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("intouch_message")]
public partial class intouch_message
{
    [Key]
    [StringLength(50)]
    public string im_machine_name { get; set; } = null!;

    public int im_terminal_id { get; set; }

    [Column(TypeName = "text")]
    public string im_message { get; set; } = null!;
}
