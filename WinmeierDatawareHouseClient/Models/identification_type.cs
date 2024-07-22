using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class identification_type
{
    [Key]
    public int idt_id { get; set; }

    public bool idt_enabled { get; set; }

    public int idt_order { get; set; }

    [StringLength(50)]
    public string idt_name { get; set; } = null!;

    public string? idt_description { get; set; }

    public string? idt_regex { get; set; }

    [StringLength(50)]
    public string? idt_aux_name { get; set; }

    [StringLength(2)]
    public string idt_country_iso_code2 { get; set; } = null!;
}
