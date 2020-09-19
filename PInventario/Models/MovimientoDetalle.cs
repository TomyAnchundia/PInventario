using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PInventario.Models
{
    public class MovimientoDetalle
    {

        //atributos
        [Key]
        public int Id_movimiento_detalle { get; set; }
     
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "Fecha de movimiento")]
        public System.DateTime Fecha_movimiento { get; set; }

       
        public int Cantidad { get; set; }



        //relaciones

        public int Id_producto { get; set; }
        [ForeignKey("Id_producto")]
        public virtual Producto Producto { get; set; }

        

        public int Id_movimiento { get; set; }
        [ForeignKey("Id_movimiento")]
        public virtual Movimiento Movimiento { get; set; }

       
    }
}