using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicaci_n_de_Remesas_Internacionales_con_Gesti_n_de_Transacciones_en_D_lares_y_Bitcoin.Models
{
    [Table ("t_transacciones")]
    public class transacciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }  // Puede ser "USD" o "BTC"
        public string Descripcion { get; set; } 
    }
}