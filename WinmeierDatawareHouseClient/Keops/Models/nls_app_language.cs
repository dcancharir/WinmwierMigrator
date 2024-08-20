using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("nls_app_language")]
public partial class nls_app_language
{
    [Key]
    public int nls_id { get; set; }

    public int nls_app_id { get; set; }

    public int nls_lang_id { get; set; }

    public long? nls_resource_id { get; set; }

    [MaxLength(50)]
    public byte[]? nls_hash { get; set; }
}
