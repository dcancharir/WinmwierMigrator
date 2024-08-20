using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("db_client_id", "db_common_build_id", "db_client_build_id", "db_release_id")]
public partial class db_version_interface_3g
{
    [Key]
    public int db_client_id { get; set; }

    [Key]
    public int db_common_build_id { get; set; }

    [Key]
    public int db_client_build_id { get; set; }

    [Key]
    public int db_release_id { get; set; }

    [StringLength(50)]
    public string? db_updated_script { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? db_updated { get; set; }

    [StringLength(1000)]
    public string? db_description { get; set; }
}
