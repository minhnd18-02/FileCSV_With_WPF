using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;


public class MarkReports
{
    [Key]
    public string? StudentId { get; set; }
    public string? Province { get; set; }
    public decimal? Mathematics { get; set; }
    public decimal? Literature { get; set; }
    public decimal? Physics { get; set; }
    public decimal? Chemistry { get; set; }
    public decimal? Biology { get; set; }
    public decimal? CNS { get; set; }
    public decimal? History { get; set; }
    public decimal? Geography { get; set; }
    public decimal? Civic_Education { get; set; }
    public decimal? CSS { get; set; }
    public decimal? English { get; set; }


}
