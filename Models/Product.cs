using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatoRestaurant.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public UInt16 Id { get; set; }

        [Display(Name = "nome")]
        [StringLength(60, ErrorMessage = "O {0} deve possuir no maximo {1} caracteres")]
        [Required(ErrorMessage = "Informe o seu {0}")]
        public string Name { get; set; }

        [Display(Name = "Descriçao")]
        [StringLength(2000, ErrorMessage = "A {0} deve possuir no maximo {1} caracteres")]
        public string Description { get; set; }

        [Display(Name = "Valor")]
        [Column(TypeName = "decimal(10,2)")]
        [Required(ErrorMessage = "Informe o seu {0}")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }

        [Display(Name = "Data de cadastro")]
        [StringLength(100, ErrorMessage = "seu {0} deve possuir no maximo {1} Caracteres")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Display(Name = "Categoria")]
        public byte CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Display(Name = "Status da reserva")]
        public byte StatusReservationId { get; set; }
        [ForeignKey("StatusReservationId")]
        public StatusReservation StatusReservation { get; set; }

        [Display(Name = "Imagem")]
        [StringLength(400)]
        public string Image { get; set; }

    }
}