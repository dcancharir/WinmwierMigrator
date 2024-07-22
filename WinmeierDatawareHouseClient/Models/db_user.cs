using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class db_user
{
    [Key]
    [StringLength(50)]
    public string du_username { get; set; } = null!;

    [MaxLength(40)]
    public byte[] du_password { get; set; } = null!;
}
