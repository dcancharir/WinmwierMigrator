using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Keyless]
public partial class alesis_parameter
{
    [StringLength(50)]
    public string? ap_sql_server_ip_address { get; set; }

    [StringLength(50)]
    public string? ap_sql_database_name { get; set; }

    [StringLength(50)]
    public string? ap_sql_user { get; set; }

    [StringLength(50)]
    public string? ap_sql_user_password { get; set; }

    [StringLength(50)]
    public string? ap_vendor_id { get; set; }
}
