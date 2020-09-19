using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace PInventario.Models
{
    public class Papeleria
    {

        //atributos
        [Key]
        public int Id_papeleria { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre_papeleria { get; set; }

        [MaxLength(10)]
        public string Contacto_papeleria { get; set; }

        [MaxLength(100)]
        public string Direccion_papeleria { get; set; }





        //Relaciones
        public virtual List<Usuario> Lista_usuarios { get; set; }

        public virtual List<Producto> Lista_productos { get; set; }
        public virtual List<ReporteProducto> Lista_reporte_productos { get; set; }
       
    
    }



}