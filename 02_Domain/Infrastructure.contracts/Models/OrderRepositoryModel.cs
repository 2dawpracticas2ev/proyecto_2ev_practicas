using System.ComponentModel.DataAnnotations;

namespace proyecto_2ev_practicas;

public class OrderRepositoryModel
{
    [Key]
    public int? id { get; set; }
    public int? product_id { get; set; }
    public DateTime date {get; set;}
}