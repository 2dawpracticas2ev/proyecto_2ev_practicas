using System.ComponentModel.DataAnnotations;

namespace proyecto_2ev_practicas;

public class ProductRepositoryModel
{
    [Key]
    public int? product_id { get; set; }
    public string? product_name { get; set; }
    public string? url_img { get; set; }
    public int? stock { get; set; }
}