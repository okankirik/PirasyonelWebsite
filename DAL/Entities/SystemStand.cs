using System.ComponentModel.DataAnnotations;

namespace PirasyonelWebsite.DAL.Entities;

public class SystemStand
{
	public int Id { get; set; }
    [Display(Name = "Stand Adı")]
    public string StandName { get; set; }
    [Display(Name = "Stand Kategorisi")]
    public string StandCategoryName { get; set; }
    [Display(Name = "Resim 1")]
    public string Image1 { get; set; }
    [Display(Name = "Resim 2")]
    public string Image2 { get; set; }
    [Display(Name = "Resim 3")]
    public string? Image3 { get; set; }
    [Display(Name = "Resim 4")]
    public string? Image4 { get; set; }
    [Display(Name = "Resim 5")]
    public string? Image5 { get; set; }

}
