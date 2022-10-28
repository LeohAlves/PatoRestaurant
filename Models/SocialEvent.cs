using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatoRestaurant.Models
{
    [Table("SocialEvent")]
    public class SocialEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public UInt16 Id { get; set; }

        [Display(Name = "nome")]
        [Required(ErrorMessage = "Informe o {0}")]
        [StringLength(30, ErrorMessage = "O {0} deve possuir no maximo {1} caracteres")]
        public string Name { get; set; }

        [Display(Name = "Descriçao")]
        [StringLength(2000, ErrorMessage = "A {0} deve possuir no maximo {1} caracteres")]
        public string Description { get; set; }

        [Display(Name = "Data do evento")]
        [Required(ErrorMessage = "Informe a {0}")]
        public DateTime EventDate { get; set; }

        [Display(Name = "Imagem")]
        [StringLength(400)]
        public string Image { get; set; }

    }
}