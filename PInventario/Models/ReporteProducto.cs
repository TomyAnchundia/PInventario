using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PInventario.Models
{
    public class ReporteProducto
    {

        //atributos
        [Key]
        public int Id_reporte_producto { get; set; }

     

        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "Fecha de emision")]
        public System.DateTime Fecha_emision { get; set; }
        public string Descripcion_reporte { get; set; }




        //relaciones
        public int Id_papeleria { get; set; }
        [ForeignKey("Id_papeleria")]
        public virtual Papeleria Papeleria { get; set; }

        public virtual List<Producto> Lista_productos { get; set; }




    }
}