using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Application.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "La cantidad max de caracteres es de 50")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "La cantidad max de caracteres es de 50")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime Creation_Date { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime HashKey { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime HashIV { get; set; }
    }
}