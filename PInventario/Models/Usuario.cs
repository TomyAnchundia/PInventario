using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PInventario.Models
{
    public class Usuario
    {
        //atributos
        [Key]
        public int Id_usuario { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
        [MaxLength(30)]
        public string Apellido { get; set; }
        [MaxLength(20)]
        public string Nombre_usuario { get; set; }
        [MaxLength(20)]
        public string Contrasena { get; set; }
        
        


        //Relaciones
        public int Id_papeleria { get; set; }
        [ForeignKey("Id_papeleria")]
        public virtual Papeleria Papeleria { get; set; }
    }
}