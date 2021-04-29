using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Models
{


    [Table("Contactos")]

    public class Contacto
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        
        public int Id { get; set;}
        [Required]
        
        public string Nombres { get; set; }
        [Required]

        public string Apellidos { get; set; }

        [Required, MaxLength(14), Display(Name= "Telefono Movil")]


        public string TelefonoMovil { get; set; }


        [MaxLength(14), Display(Name = "Telefono Casa")]

        public string TelefonoCasa { get; set; }


        [MaxLength(14), Display(Name = "Telefono Trabajo ")]
        
        public string TelefonoTrabajo { get; set; }


        public string Empresa { get; set; }

        [Display(Name = "Dirección")]

        public string  Direccion { get; set; }

        [Display(Name= "Cédula")]

        public string Cedula { get; set; }

        public string Correo { get; set; }

        [Display(Name = "Fecha de Nacimiento")]

        public DateTime? FechaNacimiento { get; set; }

        public string Instagram { get; set; }

        public string Facebook { get; set; }


        [Display(Name = "Página Web")]

        public string PaginaWeb { get; set; }

        [Display(Name = "Puesto de Trabajo")]
        public string PuestoTrabajo { get; set; }

        public string Nota { get; set; }

        public byte[] Foto { get; set; }

        public TipoContacto Tipo { get; set; }


    }
}
