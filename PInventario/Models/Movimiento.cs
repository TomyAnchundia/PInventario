using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PInventario.Models
{
    public class Movimiento
    {

        //atributos
        [Key]
        public int Id_movimiento { get; set; }

        [MaxLength(20)]
        public string Tipo_movimimiento { get; set; }






        //relaciones
        public virtual List<MovimientoDetalle> Lista_movimiento_detalle { get; set; }
    }
}