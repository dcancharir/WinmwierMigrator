using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("account_photo")]
public partial class account_photo
{
    [Key]
    public long aph_account_id { get; set; }

    public byte[]? aph_photo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime aph_last_update { get; set; }
}
