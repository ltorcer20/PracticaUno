using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formulario.Models
{
       [Table("t_datos")]
     
    public class Formularios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor ingrese un Nombre")]
        [Display(Name="name")]
        [Column("name")]

        public string nombre { get; set; }

        [Required(ErrorMessage = "Por favor ingrese un Apellido")]
        [Display(Name="lastname")]
        [Column("lastname")]

        public string apellido { get; set; }

        [Required(ErrorMessage = "Por favor ingrese un Distrito")]
        [Display(Name="district")]
        [Column("district")]

        public string distrito { get; set; }


        [Column("bank")]

        public string banco { get; set; }


        [Column("age")]

        public int edad { get; set; }


        [Column("gender")]

        public string genero { get; set; }

        [Column("author")]

        public string author { get; }

        [NotMapped]

        public String Respuesta { get; set; }
    }
}