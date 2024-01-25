using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;

public class MarkReport
{
    [Key]
    [Name("SBD")]
    public string? Sbd { get; set; }
    [Name("Toan")]
    public decimal? Toan { get; set; }
    [Name("Van")]
    public decimal? Van { get; set; }
    [Name("Ly")]
    public decimal? Ly { get; set; }
    [Name("Sinh")]
    public decimal? Sinh { get; set; }
    [Name("Ngoai ngu")]
    public decimal? Ngoaingu { get; set; }
    [Name("Year")]
    public int? Year { get; set; }
    [Name("Hoa")]
    public decimal? Hoa { get; set; }
    [Name("Lich su")]
    public decimal? Lichsu { get; set; }
    [Name("Dia ly")]
    public decimal? Dialy { get; set; }
    [Name("GDCD")]
    public decimal? Gdcd { get; set; }
    [Name("MaTinh")]
    public int? MaTinh { get; set; }


}

