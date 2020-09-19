using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PInventario.Models
{
    public class Marca
    {

        //atributos
    [Key]
        public int Id_marca { get; set; }
        [Required]
        [MaxLength(20)]
        public string Nombre_marca { get; set; }


        //relaciones
        public virtual List<Producto> Lista_productos { get; set; }

    }
}