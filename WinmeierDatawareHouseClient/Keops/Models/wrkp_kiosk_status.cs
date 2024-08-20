using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("wrkp_kiosk_status")]
public partial class wrkp_kiosk_status
{
    [Key]
    public long wks_cr_id { get; set; }

    public int? wks_billAcceptorStatus { get; set; }

    public int? wks_coinAcceptorStatus { get; set; }

    public int? wks_titoPrinterStatus { get; set; }

    public int? wks_voucherPrinter { get; set; }

    public int? wks_barcodeReader { get; set; }

    public int? wks_playerCardReader { get; set; }

    public int? wks_bankCardReader { get; set; }

    public int? wks_NFC { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wks_updated_date { get; set; }
}
