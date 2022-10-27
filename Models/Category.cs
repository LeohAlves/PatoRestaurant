using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatoRestaurant.Models
{
    [Table("Category")]
    public class Category
    {

    [Key]
    //[DatabasGenerated(DatabaseGenerateOption)]
     public byte Id  { get; set; }
     public string Name { get; set; }
     public string Image { get; set; }
     public string banner { get; set; }
    }
}