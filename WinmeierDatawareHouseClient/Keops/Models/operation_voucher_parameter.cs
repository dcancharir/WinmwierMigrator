using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class operation_voucher_parameter
{
    [Key]
    public int ovp_operation_code { get; set; }

    public bool ovp_enabled { get; set; }

    public bool ovp_generate { get; set; }

    public bool ovp_reprint { get; set; }

    public int ovp_print_copy { get; set; }

    public int ovp_question { get; set; }

    public int ovp_category { get; set; }
}
