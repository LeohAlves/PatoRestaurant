using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatoRestaurant.Models
{
    [Table("Reservation")]
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        [Display(Name = "nome")]
        [StringLength(60, ErrorMessage = "O {0} deve possuir no maximo {1} caracteres")]
        [Required(ErrorMessage = "Informe o seu {0}")]

        public string Name { get; set; }

        [Display(Name = "Data da Reserva")]
        [Required(ErrorMessage = "Informe a {0} ")]
        public DateTime ReservationDate { get; set; }

        [Display(Name = "Celular")]
        [StringLength(20, ErrorMessage = "O {0} deve possuir no maximo {1} caracteres")]
        [Required(ErrorMessage = "Informe o seu {0}")]

        public string Phone { get; set; }

        [Display(Name = "Convidados")]
        [Required(ErrorMessage = "Informe o Numero de {0}")]
        public Byte Guest { get; set; }

        [Display(Name = "Email")]
        [StringLength(100, ErrorMessage = "seu {0} deve possuir no maximo {1} Caracteres")]
        [EmailAddress(ErrorMessage = "Informe um e-mail valido!!")]
        public string Email { get; set; }

        [Display(Name = "Data de cadastro")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Display(Name ="Status da reserva")]
        public byte StatusReservationId { get; set; }
        [ForeignKey("StatusReservationId")]
        public StatusReservation StatusReservation { get; set; }

    }
}