using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class account_major_prize
{
    [Key]
    public long amp_operation_id { get; set; }

    public long amp_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime amp_datetime { get; set; }

    [Column(TypeName = "money")]
    public decimal amp_prize { get; set; }

    [Column(TypeName = "money")]
    public decimal? amp_witholding_tax1 { get; set; }

    [Column(TypeName = "money")]
    public decimal? amp_witholding_tax2 { get; set; }

    [Column(TypeName = "money")]
    public decimal? amp_witholding_tax3 { get; set; }

    [StringLength(150)]
    public string amp_player_name { get; set; } = null!;

    [StringLength(20)]
    public string amp_player_id1 { get; set; } = null!;

    [StringLength(20)]
    public string amp_player_id2 { get; set; } = null!;

    [StringLength(50)]
    public string? amp_player_address01 { get; set; }

    [StringLength(50)]
    public string? amp_player_address02 { get; set; }

    [StringLength(50)]
    public string? amp_player_address03 { get; set; }

    [StringLength(50)]
    public string? amp_player_address04 { get; set; }

    [StringLength(50)]
    public string? amp_player_address05 { get; set; }

    [StringLength(50)]
    public string? amp_player_address06 { get; set; }

    [StringLength(50)]
    public string? amp_player_address07 { get; set; }

    [StringLength(50)]
    public string? amp_player_address08 { get; set; }

    [StringLength(50)]
    public string? amp_player_address09 { get; set; }

    [StringLength(50)]
    public string? amp_player_address10 { get; set; }

    [StringLength(150)]
    public string? amp_business_name { get; set; }

    [StringLength(20)]
    public string? amp_business_id1 { get; set; }

    [StringLength(20)]
    public string? amp_business_id2 { get; set; }

    [StringLength(150)]
    public string? amp_representative_name { get; set; }

    [StringLength(20)]
    public string? amp_representative_id1 { get; set; }

    [StringLength(20)]
    public string? amp_representative_id2 { get; set; }

    public long? amp_document_id1 { get; set; }

    public long? amp_document_id2 { get; set; }

    public long? amp_document_id3 { get; set; }

    [StringLength(50)]
    public string? amp_player_name1 { get; set; }

    [StringLength(50)]
    public string? amp_player_name2 { get; set; }

    [StringLength(50)]
    public string? amp_player_name3 { get; set; }

    public int? amp_player_gender { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? amp_player_birth_date { get; set; }

    public bool? amp_generated_document { get; set; }

    [Column(TypeName = "money")]
    public decimal? amp_witholding_tax4 { get; set; }

    [Column(TypeName = "money")]
    public decimal? amp_witholding_tax5 { get; set; }

    public long? amp_1042s_unique_form_identifier { get; set; }

    public bool? amp_unauthorized { get; set; }

    [StringLength(10)]
    public string? amp_player_Zip { get; set; }

    [StringLength(50)]
    public string? amp_player_FiscalID { get; set; }

    public int? amp_player_IsNational { get; set; }
}