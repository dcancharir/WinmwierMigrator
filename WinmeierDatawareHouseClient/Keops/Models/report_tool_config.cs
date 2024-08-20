using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("report_tool_config")]
public partial class report_tool_config
{
    public int rtc_report_tool_id { get; set; }

    public int rtc_form_id { get; set; }

    public int rtc_location_menu { get; set; }

    [Column(TypeName = "xml")]
    public string rtc_report_name { get; set; } = null!;

    [StringLength(400)]
    public string rtc_store_name { get; set; } = null!;

    [Column(TypeName = "xml")]
    public string rtc_design_filter { get; set; } = null!;

    [Column(TypeName = "xml")]
    public string rtc_design_sheets { get; set; } = null!;

    public int rtc_mailing { get; set; }

    public int rtc_status { get; set; }

    public int rtc_mode_type { get; set; }

    [Column(TypeName = "xml")]
    public string? rtc_html_header { get; set; }

    [Column(TypeName = "xml")]
    public string? rtc_html_footer { get; set; }
}
