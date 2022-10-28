using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatoRestaurant.Models
{
    [Table("Review")]
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        [Display(Name = "nome")]
        [Required(ErrorMessage = "Informe o {0}")]
        [StringLength(30, ErrorMessage = "O {0} deve possuir no maximo {1} caracteres")]
        public string Name { get; set; }

        [Display(Name = "Texto da avaliaçao")]
        [StringLength(2000, ErrorMessage = "O {0} deve possuir no maximo {1} caracteres")]
        public string ReviewText { get; set; }

        [Display(Name = "Data da Avaliação")]
        public DateTime ReviewDate { get; set; } = DateTime.Now;

        [Display(Name = "Foto do avaliador")]
        [StringLength(400)]
        public string Image { get; set; }

        [Display(Name ="Nota")]
        public byte Rating { get; set; }

    }
}