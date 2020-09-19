using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PInventario.Models
{
    public class Producto
    {
        //atributos
        [Key]
        public int Id_producto { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre_producto { get; set; }
        public float Precio_compra { get; set; }
        public float Precio_venta { get; set; }
        


        //relaciones
        public int Id_categoria { get; set; }
        [ForeignKey("Id_categoria")]
        public virtual Categoria Categoria { get; set; }

        public int Id_marca { get; set; }
        [ForeignKey("Id_marca")]
        public virtual Marca Marca { get; set; }


        public virtual List<MovimientoDetalle> Lista_movimiento_detalle { get; set; }

        
        

    }
}
