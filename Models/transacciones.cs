using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_remesas_parcial.Models
{
    [Table("t_transacciones")]
    public class transacciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Destino { get; set; }
        public string? Remitente { get; set; }
        public string? PaisOrigen { get; set; }
        public string? PaisDestino { get; set; }
        public decimal? MontoEnviado { get; set; }
        public string? TipoMoneda { get; set; }
        public decimal? Cambio { get; set; }
        public decimal? MontoFinal { get; set; }
        public string? Status { get; set; } = "En Proceso";

        public void CalcularMonto()
        {
            MontoFinal = Cambio * MontoEnviado;
        }
    }
}